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

namespace eBuy.View.User.Registration
{
    public partial class ACTUserRegistration : Window
    {
        Model.TOUser TOUser = new Model.TOUser();
        Model.DAO.DAOUser uDAO = new Model.DAO.DAOUser();

        public ACTUserRegistration()
        {
            InitializeComponent();

            CanvasStepOne.Visibility = Visibility.Visible;
            CanvasStepTwo.Visibility = Visibility.Hidden;
            CanvasStepThree.Visibility = Visibility.Hidden;
        }
        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void psbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            progressBar.Value = (TOUser.verifyPassword(psbPassword.Password));
            if (progressBar.Value <= 25)
            {
                progressBar.Foreground = Brushes.Red;
                lblVerifyPassword.Content = "Senha fraca.";
                lblVerifyPassword.Visibility = Visibility.Visible;
                lblVerifyPassword.Foreground = Brushes.Red;
            }
            else if (progressBar.Value <= 50)
            {
                progressBar.Foreground = Brushes.Yellow;
                lblVerifyPassword.Visibility = Visibility.Visible;
                lblVerifyPassword.Content = "Senha mediana.";
                lblVerifyPassword.Foreground = Brushes.Yellow;
            }
            else if (progressBar.Value >= 75)
            {
                progressBar.Foreground = Brushes.Green;
                lblVerifyPassword.Visibility = Visibility.Visible;
                lblVerifyPassword.Content = "Senha forte.";
                lblVerifyPassword.Foreground = Brushes.Green;
            }

            if (psbConfirmPassword.Password == psbPassword.Password)
            {
                psbPassword.BorderBrush = Brushes.Green;
                psbConfirmPassword.BorderBrush = Brushes.Green;
                TOUser.Password = psbConfirmPassword.Password.ToString();
            }
            else
            {
                psbPassword.BorderBrush = Brushes.Red;
                psbConfirmPassword.BorderBrush = Brushes.Red;
            }

            if(psbPassword.Password == "" && psbConfirmPassword.Password == "")
            {
                psbPassword.BorderBrush = Brushes.White;
                psbConfirmPassword.BorderBrush = Brushes.White;
                lblVerifyPassword.Visibility = Visibility.Hidden;
            }
        }

        private void psbConfirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            progressBar.Value = (TOUser.verifyPassword(psbPassword.Password));
            if (progressBar.Value <= 25)
            {
                progressBar.Foreground = Brushes.Red;
                lblVerifyPassword.Content = "Senha fraca.";
                lblVerifyPassword.Visibility = Visibility.Visible;
                lblVerifyPassword.Foreground = Brushes.Red;
            }
            else if (progressBar.Value <= 50)
            {
                progressBar.Foreground = Brushes.Yellow;
                lblVerifyPassword.Visibility = Visibility.Visible;
                lblVerifyPassword.Content = "Senha mediana.";
                lblVerifyPassword.Foreground = Brushes.Yellow;
            }
            else if (progressBar.Value >= 75)
            {
                progressBar.Foreground = Brushes.Green;
                lblVerifyPassword.Visibility = Visibility.Visible;
                lblVerifyPassword.Content = "Senha forte.";
                lblVerifyPassword.Foreground = Brushes.Green;
            }

            if (psbConfirmPassword.Password == psbPassword.Password)
            {
                psbPassword.BorderBrush = Brushes.Green;
                psbConfirmPassword.BorderBrush = Brushes.Green;
                TOUser.Password = psbConfirmPassword.Password.ToString();
            }
            else
            {
                psbPassword.BorderBrush = Brushes.Red;
                psbConfirmPassword.BorderBrush = Brushes.Red;
            }

            if (psbPassword.Password == "" && psbConfirmPassword.Password == "")
            {
                psbConfirmPassword.BorderBrush = Brushes.White;
                psbPassword.BorderBrush = Brushes.White;
                lblVerifyPassword.Visibility = Visibility.Hidden;
            }

        }


        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            //if past all verifications and steps.

            if (uDAO.Registration(TOUser))
            {
                ACTHouseSelection hs = new ACTHouseSelection(TOUser);
                hs.ShowDialog();
                ACTMessages message = new ACTMessages(TOUser, "eBuy!", "Cadastro realizado com sucesso!", 1);
                message.ShowDialog();
                CanvasStepOne.Visibility = Visibility.Visible;
                CanvasStepTwo.Visibility = Visibility.Hidden;
                CanvasStepThree.Visibility = Visibility.Hidden;
                txtUser.Text = "";
                txtEmail.Text = "";
                psbPassword.Password = "";
                psbConfirmPassword.Password = "";
                txtUser.BorderBrush = Brushes.White;
                txtEmail.BorderBrush = Brushes.White;
                psbPassword.BorderBrush = Brushes.White;
                psbConfirmPassword.BorderBrush = Brushes.White;
                lblVerifyPassword.Visibility = Visibility.Hidden;
                lblSteps.Content = "Passo: 1";
                txtUser.Focus();
            }
            else
            {
                //database error.
                ACTMessages message = new ACTMessages(TOUser, "eBuy", "Algo errado aconteceu durante o cadastro.", 3);
                message.ShowDialog();
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            TOUser.Account = txtUser.Text.ToString();
            if (uDAO.VerifyAccountName(TOUser.Account))
            {
                txtUser.BorderBrush = Brushes.Red;
            }
            else
            {
                txtUser.BorderBrush = Brushes.Green;
            }
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            TOUser.Email = txtEmail.Text.ToString();
            if (TOUser.IsValidEmail(txtEmail.Text.ToString()))
            {
                txtEmail.BorderBrush = Brushes.Green;
            }
            else
            {
                txtEmail.BorderBrush = Brushes.Red;
            }
            if (uDAO.VerifyAccountEmail(TOUser.Email))
            {
                txtEmail.BorderBrush = Brushes.Red;
            }
            else
            {
                txtEmail.BorderBrush = Brushes.Green;
            }
        }

        private void btnFoward_Click(object sender, RoutedEventArgs e)
        {
            if (CanvasStepOne.Visibility == Visibility.Visible)
            {
                //verification for blank name.
                if (TOUser.Account == "")
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "O campo de usuário não pode estar vazio.", 2);
                    txtUser.BorderBrush = Brushes.Red;
                    message.ShowDialog();
                    txtUser.Focus();
                }
                //verification for an account that already uses that name.
                else if (uDAO.VerifyAccountName(TOUser.Account))
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "Já existe uma conta cadastrada com este nome.", 2);
                    txtUser.BorderBrush = Brushes.Red;
                    message.ShowDialog();
                    txtUser.Focus();
                }
                //verification for blank email.
                else if (TOUser.Email == "")
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "O campo de email não pode estar vazio.", 2);
                    txtEmail.BorderBrush = Brushes.Red;
                    message.ShowDialog();
                    txtEmail.Focus();
                }
                //verification for an account that already uses that email.
                else if (uDAO.VerifyAccountEmail(TOUser.Email))
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "Já existe uma conta cadastrada neste email.", 2);
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
                //verification for blank password.
                else if (psbPassword.Password.ToString() == "")
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "O campo de senha não pode estar vazio.", 2);
                    psbPassword.BorderBrush = Brushes.Red;
                    message.ShowDialog();
                    psbPassword.Focus();
                }
                //verification for blank password.
                else if (psbConfirmPassword.Password.ToString() == "")
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "O campo de senha não pode estar vazio.", 2);
                    psbConfirmPassword.BorderBrush = Brushes.Red;
                    message.ShowDialog();
                    psbConfirmPassword.Focus();
                }
                else
                {
                    CanvasStepOne.Visibility = Visibility.Hidden;
                    CanvasStepTwo.Visibility = Visibility.Visible;
                    lblVerifyPassword.Visibility = Visibility.Hidden;
                    lblSteps.Content = "Passo: 2";
                }

            }
            else if (CanvasStepTwo.Visibility == Visibility.Visible)
            {
                if(TOUser.Name == "")
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "O campo de nome não pode estar vazio.", 2);
                    txtUser.BorderBrush = Brushes.Red;
                    message.ShowDialog();
                    txtUser.Focus();
                }
                else if(TOUser.SirName == "")
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "O campo de sobrenome não pode estar vazio.", 2);
                    txtUser.BorderBrush = Brushes.Red;
                    message.ShowDialog();
                    txtUser.Focus();
                }else if(TOUser.Credit <= 0)
                {
                    ACTMessages message = new ACTMessages(TOUser, "eBuy", "O campo de capital não pode estar vazio.", 2);
                    txtUser.BorderBrush = Brushes.Red;
                    message.ShowDialog();
                    txtUser.Focus();
                }
                else{
                    CanvasStepOne.Visibility = Visibility.Hidden;
                    CanvasStepTwo.Visibility = Visibility.Hidden;
                    CanvasStepThree.Visibility = Visibility.Visible;
                    btnFoward.Visibility = Visibility.Hidden;
                    btnRegister.Visibility = Visibility.Visible;
                    lblSteps.Content = "Passo: 3";
                    btnFoward.Visibility = Visibility.Hidden;
                    btnRegister.Visibility = Visibility.Visible;
                }
            }

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TOUser.Name = txtName.Text.ToString();
        }

        private void txtSirName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TOUser.SirName = txtSirName.Text.ToString();
        }

        private void txtInitialCapital_TextChanged(object sender, TextChangedEventArgs e)
        {
            TOUser.Credit = Double.Parse(txtInitialCapital.Text.ToString());
            TOUser.CreditAvaliable = Double.Parse(txtInitialCapital.Text.ToString());
        }

        private void btnSelectPic_Click(object sender, RoutedEventArgs e)
        {
            //creates the dialog for selection 
            Microsoft.Win32.OpenFileDialog selection = new Microsoft.Win32.OpenFileDialog();

            //default file extasion configurated for images. 
            selection.DefaultExt = ".*";
            selection.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            //boolean for check selection further in the code.
            Nullable<bool> result = selection.ShowDialog();

            //get the selected file.
            if (result == true)
            {
                //loads the image into the imgseries component.
                imgUser.Source = new BitmapImage(new Uri(selection.FileName));
            }

            if (!System.IO.Directory.Exists(@"C:\eBuy"))
            {
                System.IO.Directory.CreateDirectory(@"C:\eBuy");
                File.Copy(selection.FileName, @"C:\eBuy\" + TOUser.Account + ".png", true);
            }
            else
            {
                File.Copy(selection.FileName, @"C:\eBuy\" + TOUser.Account + ".png", true);
            }
        }
    }
}
