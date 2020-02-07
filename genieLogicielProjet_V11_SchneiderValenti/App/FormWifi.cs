﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using DAL;

namespace App
{
    public partial class FormWifi : Form
    {
        private bool isUpdateMode;
        private User userConnected;
        private IWifiRepository wifiRepository;
        private IList<Wifi> pointsWifi;
        
        public FormWifi(User user)
        {
            InitializeComponent();
            //mise à l'état d'affichage
            isUpdateMode = false;

            //chargement des données
            this.userConnected = user;
            this.wifiRepository = new WifiRepository();
            this.pointsWifi = wifiRepository.GetAll();

            //Affichage
            //RefreshList();
            Display();
        }

        private void Display()
        {
            try
            {
                //remplissage de la list Box des points wifi d'un utilisateur
                WifiLB.DataSource = pointsWifi;

                Wifi selectedWifi = new Wifi();
                //préaffichage des données du point wifi
                selectedWifi = (Wifi)WifiLB.SelectedItem;
                titleTB.Text = selectedWifi.Title;
                ssidTB.Text = selectedWifi.SSID;
                passwordTB.Text = selectedWifi.Password;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void RefreshList()
        {
            try
            {
                WifiLB.Items.Clear();
                string display = "";
                for (int i = 0; i < pointsWifi.Count(); i++)
                {
                    display = pointsWifi[i].Title;
                    WifiLB.Items.Add(display);
                }
                WifiLB.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        private void WifiLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //permet de gérer le changement de sélection dans la liste
            if (WifiLB.SelectedItem != null)
            {
                Display();
            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné !", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Form AddForm = new AddForm(userConnected);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (isUpdateMode)
            {
                Wifi ptWifi = (Wifi)WifiLB.SelectedItem;
                ptWifi.SSID = ssidTB.Text;
                ptWifi.Title = titleTB.Text;
                ptWifi.Password = passwordTB.Text;

                //enregistrement des modifications
                wifiRepository.Update(ptWifi);
            }
            //passage en mode édition
            SwitchUpdateMode();

            //feedback après enregistrement des modifications
            if (!isUpdateMode)
            {
                MessageBox.Show("Modifications prises en compte", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SwitchUpdateMode()
        {
            isUpdateMode = !isUpdateMode;
            ChangeColor();

            //deux états possibles pour le bouton "update" : Enregistrer ou Modifier 
            updateButton.Text = (isUpdateMode) ? "Enregistrer" : "Modifier";

            //deux états pour les champs : modifiables ou lecture seule
            ssidTB.ReadOnly = !ssidTB.ReadOnly;
            titleTB.ReadOnly = !titleTB.ReadOnly;
            passwordTB.ReadOnly = !passwordTB.ReadOnly;

            //deux états pour les autres boutons : actif ou inactif
            deleteButton.Enabled = !deleteButton.Enabled;
            addButton.Enabled = !addButton.Enabled;
        }

        private void ChangeColor()
        {
            //deux couleurs pour les champs :
            //blanc en mode édition
            if (isUpdateMode)
            {
                //titleTB.BackColor = Color.White;
                ssidTB.BackColor = Color.White;
                passwordTB.BackColor = Color.White;
            }
            //gris en lecture seule
            else
            {
                //titleTB.BackColor = Color.Gainsboro;
                ssidTB.BackColor = Color.Gainsboro;
                passwordTB.BackColor = Color.Gainsboro;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //demande de confirmation
            DialogResult confirm = MessageBox.Show("Êtes vous sûr(e) de vouloir supprimer le compte ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (confirm == DialogResult.Yes)
            {
                // suppression de compte
                wifiRepository.Delete((Wifi)WifiLB.SelectedItem);
                RefreshList();
            }
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
            int force = EvaluatePassword();
            
            if (force <= 20)
            {
                progressBarMdp.Value = force;
            }
            else if (force <= 40)
            {
                progressBarMdp.Value = force;
            }

            else if (force <= 60)
            {
                progressBarMdp.Value = force;
            }
            else if (force <= 80)
            {
                progressBarMdp.Value = force;
            }
            else if (force < 80)
            {
                progressBarMdp.Value = force;
            }
        }
    }
}
