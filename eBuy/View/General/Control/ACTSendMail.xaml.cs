using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace eBuy.View.General.Control
{
    public partial class ACTSendMail : Window
    {
        Model.TOUser TOUser = new Model.TOUser();
        Model.DAO.DAOUser uDAO = new Model.DAO.DAOUser();
        
        public ACTSendMail()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            //verification for blank email.
            if (TOUser.Email == "")
            {
                ACTMessages message = new ACTMessages(TOUser, "eBuy", "O campo de email não pode estar vazio.", 2);
                txtEmail.BorderBrush = Brushes.Red;
                message.ShowDialog();
                txtEmail.Focus();
            }
            //verification for valid email.
            else if (TOUser.IsValidEmail(TOUser.Email) == false)
            {
                ACTMessages message = new ACTMessages(TOUser, "eBuy", "Email inválido.", 2);
                txtEmail.BorderBrush = Brushes.Red;
                message.ShowDialog();
                txtEmail.Focus();
            }
            //verification for an account that already uses that email.
            else if (uDAO.VerifyAccountEmail(TOUser.Email))
            {

                //generate method to sendmail.

                //email sent.
                txtEmail.BorderBrush = Brushes.White;
                ACTMessages message = new ACTMessages(TOUser, "eBuy", "Email enviado!", 1);
                message.ShowDialog();

            }
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            TOUser.Email = txtEmail.Text.ToString();

            //verification for valid email.
            if (TOUser.IsValidEmail(TOUser.Email))
            {
                txtEmail.BorderBrush = Brushes.Green;
            }
            else
            {
                txtEmail.BorderBrush = Brushes.Red;
            }
        }
    }
}
