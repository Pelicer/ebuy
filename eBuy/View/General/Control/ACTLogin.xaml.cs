using eBuy.View.General;
using eBuy.View.General.Control;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    public partial class ACTLogin : Window
    {
        public ACTLogin()
        {
            InitializeComponent();
            if (Directory.Exists(@"C:\eBuy"))
            {
                //Delete on tempporary files in cache.
                string path = @"C:\eBuy";
                string filesToDelete = @"*Temp*.png";
                string[] fileList = Directory.GetFiles(path, filesToDelete);

                foreach (string file in fileList)
                {
                    File.Delete(file);
                }
            }
            else
            {
                System.IO.Directory.CreateDirectory(@"C:\eBuy");
            }
        }

        public void ACTLoginSeasonStarted()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            //exiting application.
            System.Environment.Exit(0);
        }

        private void lblRegister_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //calling registration screen.            
            View.User.Registration.ACTUserRegistration registration = new View.User.Registration.ACTUserRegistration();
            registration.ShowDialog();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //loggin in.
            Model.DAO.DAOUser uDAO = new Model.DAO.DAOUser();
            Model.TOUser tUser = new Model.TOUser();

            tUser = uDAO.Login(txtUser.Text, psbPassword.Password.ToString());
            if(tUser.Id != 0)
            {
                ACTHome home = new ACTHome(tUser);
                ACTMessages message = new ACTMessages(tUser, "eBuy", "Bem-vindo ao eBuy, " + tUser.Name + "!", 1);
                message.ShowDialog();
                home.Show();
                this.Close();
            }
            else
            {
                ACTMessages message = new ACTMessages(tUser, "eBuy", "Algo errado aconteceu durante o login.", 3);
                message.ShowDialog();
            }


        }

        private void lblSenha_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //calling send mail screen.
            ACTSendMail mail = new ACTSendMail();
            mail.ShowDialog();
        }
    }
}
