using System;
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
    public partial class Connexion : Form
    {
        private IList<User> utilisateurs;
        private IUserRepository utilRepository;
        private AccueilComptes accueil;
        public Connexion(IUserRepository utilRepository)
        {
            InitializeComponent();
            this.utilRepository = utilRepository;
            utilisateurs = utilRepository.GetAll();
            
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            string identifiant, mdpPrincipal;
            identifiant = textBoxId.Text;
            mdpPrincipal = textBoxMdp.Text;

            //Gestion de la page de connetion
            bool correspondance = false;
            User user_match = new User();
            foreach (User user in utilisateurs)
            {
                if (user.NameUser == identifiant && user.MainPassword == mdpPrincipal)
                {
                    correspondance = true;
                    user_match = user;
                }
            }
            if (correspondance)
            {
                accueil = new AccueilComptes(user_match);
                
                if (accueil.ShowDialog() != DialogResult.OK)
                {
                    DialogResult leave = MessageBox.Show("Êtes vous sûr(e) de vouloir quitter la page ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (leave == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Utilisateur inconnu ou mot de passe erroné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
