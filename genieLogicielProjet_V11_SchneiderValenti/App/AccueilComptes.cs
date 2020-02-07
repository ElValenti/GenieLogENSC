using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    /// <summary>
    /// Fenêtre principale de l'IHM
    /// </summary>
    public partial class AccueilComptes : Form
    {
        private bool isUpdateMode;
        private User userConnected;
        private IAccountRepository accountRepository;
        private IList<Account> comptes;
        private IList<Account> comptesUser;



        public AccueilComptes(User user)
        {
            InitializeComponent();
            //mise à l'état d'affichage
            isUpdateMode = false;
            
            //chargement des données
            this.userConnected = user;
            this.accountRepository = new AccountRepository();
            this.comptes = accountRepository.GetAll();
            comptesUser = new List<Account>();
            foreach (Account a in comptes)
            {
                if (a.User == userConnected)
                {
                    comptesUser.Add(a);
                }
            }

            //Affichage des données
            RefreshListAccount();
            Affichage();
        }

        private void Affichage()
        {
            try
            {
                //remplissage de la list Box des comptes d'un utilisateur
                ComptesLB.DataSource = comptesUser;

                Account selectedCompte = new Account();
                //préaffichage des données du compte
                selectedCompte = (Account)ComptesLB.SelectedItem;
                titleTB.Text = selectedCompte.Title;
                loginTB.Text = selectedCompte.Login;
                passwordTB.Text = selectedCompte.Password;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void RefreshListAccount()
        {
            try
            {
                ComptesLB.Items.Clear();
                string display = "";
                for (int i = 0; i < comptesUser.Count(); i++)
                {
                    display = comptesUser[i].Title;
                    ComptesLB.Items.Add(display);
                }
                ComptesLB.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        

        private void ComptesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //permet de gérer le changement de sélection dans la liste
            if (ComptesLB.SelectedItem != null)
            {
                Affichage();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form AddForm = new AddForm(accountRepository, userConnected);
            AddForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (isUpdateMode)
            {
                Account a = (Account)ComptesLB.SelectedItem;
                a.Login = loginTB.Text;
                a.Title = titleTB.Text;
                a.Password = passwordTB.Text;
                
                //enregistrement des modifications
                accountRepository.Update(a);
            }
            //passage en mode édition
            SwitchUpdateMode();

            //feedback après enregistrement des modifications
            if (!isUpdateMode)
            {
                MessageBox.Show("Modifications prises en compte", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //demande de confirmation
            DialogResult confirm = MessageBox.Show("Êtes vous sûr(e) de vouloir supprimer le compte ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirm == DialogResult.Yes)
            { 
                // suppression de compte
                accountRepository.Delete((Account)ComptesLB.SelectedItem);
                RefreshListAccount();
            }
        }
        private void SwitchUpdateMode()
        {
            isUpdateMode = !isUpdateMode;
            ChangeColor();

            //deux états possibles pour le bouton "update" : Enregistrer ou Modifier 
            updateButton.Text = (isUpdateMode) ? "Enregistrer" : "Modifier";
            
            //deux états pour les champs : modifiables ou lecture seule
            loginTB.ReadOnly = !loginTB.ReadOnly;
            passwordTB.ReadOnly = !passwordTB.ReadOnly;
            
            //deux états pour les autres boutons : actif ou inactif
            deleteButton.Enabled = !deleteButton.Enabled;
            addButton.Enabled = !addButton.Enabled;
            buttonFormWifi.Enabled = !buttonFormWifi.Enabled;            
        }

        private void ChangeColor()
        {
            //deux couleurs pour les champs :
            //blanc en mode édition
            if (isUpdateMode)
            {
                loginTB.BackColor = Color.White;
                passwordTB.BackColor = Color.White;
            }
            //gris en lecture seule
            else
            {
                loginTB.BackColor = Color.Gainsboro;
                passwordTB.BackColor = Color.Gainsboro;
            }
        }
        private void buttonFormWifi_Click(object sender, EventArgs e)
        {
            //affichage du formulaire de gestion des points d'accès wifi
            Form FormWifi = new FormWifi(userConnected);
            FormWifi.Show();
        }


             /* calcul la valeur du mot de passe en fontion de :
             - nb de caractères minimum
             - présence de majuscules
             - présence de chiffres ou symboles

             // tiré du site https://www.e-services.uha.fr/mdp/ 
             force=bonus-malus 
             */
        public int EvaluatePassword()
        {
            string Password = passwordTB.Text;
            // Calcul des points bonus 
            int length = Password.Count();
            int upperCase = 0;
            int lowerCase = 0;
            int digit = 0;
            List<char> listDigit = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int symbol = 0;

            foreach (char element in Password)
            {
                if (Char.IsUpper(element)) { upperCase++; }
                else
                {
                    if (Char.IsLower(element)) { lowerCase++; }
                    else
                    {
                        if (listDigit.Contains(element)) { digit++; }
                        else { symbol++; }
                    }
                }
            }
            List<int> characters = new List<int> { upperCase, lowerCase, digit, symbol };

            //vérification des conditions minimales requises
            int prerequis = 0;
            foreach (int element in characters)
            {
                if (element > 0)
                { prerequis = prerequis + 1; }
            }
            if (length >= 6) { prerequis++; }
            if (prerequis < 4) { prerequis = 0; }

            int bonus = length * 4 + (length - upperCase) * 2 + (length - lowerCase) * 2 + digit * 4 + symbol * 6 + (digit + symbol) * 2 + prerequis * 2;

            // Calcul des points de malus 
            int letterAlone = 0;
            int digitAlone = 0;
            if (length == 1)
            {
                if (Char.IsUpper(Password[0]) | Char.IsLower(Password[0])) { letterAlone = 1; }
                if (listDigit.Contains(Password[0])) { digitAlone = 1; }
            }

            int charRepeted = 0;
            int upperCaseFollowed = 0;
            int lowerCaseFollowed = 0;
            int digitFollowed = 0;
            int letterSequence = 0;
            int digitSequence = 0;
            for (int i = 0; i < length - 2; i++)
            {
                if (Password[i] == Password[i + 1]) { charRepeted++; }
                if (Char.IsUpper(Password[i]) & Char.IsUpper(Password[i + 1])) { upperCaseFollowed++; }
                if (Char.IsLower(Password[i]) & Char.IsLower(Password[i + 1])) { upperCaseFollowed++; }
                if (listDigit.Contains(Password[i]) & listDigit.Contains(Password[i + 1])) { digitFollowed++; }
            }

            for (int i = 0; i < length - 3; i++)
            {
                if ((Char.IsUpper(Password[i]) | Char.IsLower(Password[i])) & (Char.IsUpper(Password[i + 1]) | Char.IsLower(Password[i + 1])) & (Char.IsUpper(Password[i]) | Char.IsLower(Password[i]))) { letterSequence++; }
                if (listDigit.Contains(Password[i]) & listDigit.Contains(Password[i + 1]) & listDigit.Contains(Password[i + 2])) { digitSequence++; }
            }

            int malus = letterAlone + digitAlone + charRepeted + upperCaseFollowed * 2 + lowerCaseFollowed * 2 + digitFollowed * 4 + letterSequence * 3 + digitSequence * 3;
            int strength = bonus - malus;
            if (strength > 100) { strength = 100; }

            return strength;
        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {
            int Force = EvaluatePassword();
            if (Force <= 20)
            {
                progressBarMdp.Value = Force;
            }
            else if (Force <= 40)
            {
                progressBarMdp.Value = Force;
            }

            else if (Force <= 60)
            {
                progressBarMdp.Value = Force;
            }
            else if (Force <= 80)
            {
                progressBarMdp.Value = Force;
            }
            else if (Force < 80)
            {
                progressBarMdp.Value = Force;
            }

        }
        
    }
}
