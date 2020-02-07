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
    public partial class AddForm : Form
    {
        private IAccountRepository accountRepository;
        private User userConnected;
        public AddForm(IAccountRepository accountRepository, User userConnected)
        {
            InitializeComponent();
            this.accountRepository = accountRepository;
            this.userConnected = userConnected;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Account accountAdded = new Account();
            accountAdded.Title = titleTB.Text;
            accountAdded.Login = newLoginTB.Text;
            accountAdded.Password = newPasswordTB.Text;
            accountAdded.User = userConnected;
            //enregistrement des données
            accountRepository.Add(accountAdded);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void mdpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
