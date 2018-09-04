using eBuy.Model;
using eBuy.Model.DAO;
using eBuy.View.General.Control;
using LiveCharts;
using LiveCharts.Wpf;
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

namespace eBuy.View.General
{
    public partial class ACTHome : Window
    {
        TOUser user = new TOUser();
        DAOProduct DAOProd = new Model.DAO.DAOProduct();
        DAOUser DAOUser = new DAOUser();
        bool status = false;
        string ver = "";
        int count = 1;
        int i = 1;

        public ACTHome(TOUser u)
        {
            user = u;
            
            InitializeComponent();
            //hidding the menu
            Canvas.Visibility = Visibility.Hidden;
            Configuration.Visibility = Visibility.Hidden;

            //setting house logo.
            if(user.House == 2)
            {
                imgS.Visibility = Visibility.Visible;

            }
            if (user.House == 1)
            {
                imgG.Visibility = Visibility.Visible;
            }
            if (user.House == 3)
            {
                imgH.Visibility = Visibility.Visible;
            }
            if (user.House == 4)
            {
                imgR.Visibility = Visibility.Visible;
            }

            //loading menu info
            lblUserName.Content = user.Name + " " + user.SirName;
            lblMoney.Content = "R$ " + user.Credit + ",00";
            lblEmail.Content = user.Email;

            //Loading the image.
            if (!System.IO.File.Exists(@"C:\eBuy\" + user.Account + ".png"))
            {
                //The image does not exists.
            }
            else
            {
                if (System.IO.File.Exists(@"C:\eBuy\" + user.Account + "Temp.png"))
                {
                    File.Copy(@"C:\eBuy\" + user.Account + ".png", @"C:\eBuy\" + user.Account + "Temp" + i + ".png", true);
                    if (System.IO.File.Exists(@"C:\eBuy\" + user.Account + "Temp" + i + ".png"))
                    {
                        i = Directory.GetFiles(@"C:\eBuy\", "*", SearchOption.TopDirectoryOnly).Length;
                        i++;
                        File.Copy(@"C:\eBuy\" + user.Account + ".png", @"C:\eBuy\" + user.Account + "Temp" + i + ".png", true);
                        imgUser.Source = new BitmapImage(new Uri(@"C:\eBuy\" + user.Account + "Temp" + i + ".png"));
                    }
                }
                else
                {
                    File.Copy(@"C:\eBuy\" + user.Account + ".png", @"C:\eBuy\" + user.Account + "Temp.png", true);
                    imgUser.Source = new BitmapImage(new Uri(@"C:\eBuy\" + user.Account + "Temp.png"));
                }
            }

            //load recents on quick menu.
            LoadScreen(user, status);            
        }

        public void LoadMenu()
        {

            //load quickmenu informations.
            TOProduct recent_1 = DAOProd.LoadRecent(user, 0);
            TOProduct recent_2 = DAOProd.LoadRecent(user, 1);
            TOProduct recent_3 = DAOProd.LoadRecent(user, 2);

            if (recent_1.Id == 0)
            {
                lblRecentTitle_1.Visibility = Visibility.Hidden;
                price_1.Visibility = Visibility.Hidden;
                type_1.Visibility = Visibility.Hidden;
                img_1.Visibility = Visibility.Hidden;
                separator_1.Visibility = Visibility.Hidden;
                date_1.Visibility = Visibility.Hidden;
            }
            else
            {
                recent_transaction.Visibility = Visibility.Hidden;
                lblRecentTitle_1.Content = recent_1.Name;
                price_1.Content = "- R$" + recent_1.Price;
                type_1.Content = recent_1.Type;
                date_1.Content = recent_1.BuyingDate;

                lblRecentTitle_1.Visibility = Visibility.Visible;
                price_1.Visibility = Visibility.Visible;
                type_1.Visibility = Visibility.Visible;
                img_1.Visibility = Visibility.Visible;
                separator_1.Visibility = Visibility.Visible;
                date_1.Visibility = Visibility.Visible;

                btnViewTransactions.Visibility = Visibility.Visible;


            }

            if (recent_2.Id == 0)
            {
                lblRecentTitle_2.Visibility = Visibility.Hidden;
                price_2.Visibility = Visibility.Hidden;
                type_2.Visibility = Visibility.Hidden;
                img_2.Visibility = Visibility.Hidden;
                separator_2.Visibility = Visibility.Hidden;
                date_2.Visibility = Visibility.Hidden;
            }
            else
            {
                lblRecentTitle_2.Content = recent_2.Name;
                price_2.Content = "- R$" + recent_2.Price;
                type_2.Content = recent_2.Type;
                date_2.Content = recent_2.BuyingDate;

                lblRecentTitle_2.Visibility = Visibility.Visible;
                price_2.Visibility = Visibility.Visible;
                type_2.Visibility = Visibility.Visible;
                img_2.Visibility = Visibility.Visible;
                separator_2.Visibility = Visibility.Visible;
                date_2.Visibility = Visibility.Visible;

                btnViewTransactions.Visibility = Visibility.Visible;

            }

            if (recent_3.Id == 0)
            {
                lblRecentTitle_3.Visibility = Visibility.Hidden;
                price_3.Visibility = Visibility.Hidden;
                type_3.Visibility = Visibility.Hidden;
                img_3.Visibility = Visibility.Hidden;
                separator_3.Visibility = Visibility.Hidden;
                date_3.Visibility = Visibility.Hidden;
            }
            else
            {
                lblRecentTitle_3.Content = recent_3.Name;
                price_3.Content = "- R$" + recent_3.Price;
                type_3.Content = recent_3.Type;
                date_3.Content = recent_3.BuyingDate;

                lblRecentTitle_3.Visibility = Visibility.Visible;
                price_3.Visibility = Visibility.Visible;
                type_3.Visibility = Visibility.Visible;
                img_3.Visibility = Visibility.Visible;
                separator_3.Visibility = Visibility.Visible;
                date_3.Visibility = Visibility.Visible;

                btnViewTransactions.Visibility = Visibility.Visible;

            }

            if (recent_1.Id == 0)
            {
                if (recent_2.Id == 0)
                {
                    if (recent_3.Id == 0)
                    {
                        recent_transaction.Visibility = Visibility.Visible;
                        btnViewTransactions.Visibility = Visibility.Hidden;
                    }
                }

            }

            lblMoney.Content = "R$ " + user.CreditAvaliable + ",00";
            lblUserName.Content = user.Name + " " + user.SirName;
            lblEmail.Content = user.Email;

            //loading configuration information.
            //loading menu configuration
            txtAccount.Text = user.Account;
            txtName.Text = user.Name;

            ver = txtAccount.Text;

            txtSirName.Text = user.SirName;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            txtCurrentCapital.Text = user.Credit.ToString();
            txtTotalSpentCapital.Text = user.CreditSpent.ToString();
            psbCurrentPassword.Password = user.Password;
            PasswordStrengh.Value = (user.verifyPassword(user.Password));
            if (PasswordStrengh.Value <= 25)
            {
                PasswordStrengh.Foreground = Brushes.Red;
            }
            else if (PasswordStrengh.Value <= 50)
            {
                PasswordStrengh.Foreground = Brushes.Yellow;
            }
            else if (PasswordStrengh.Value >= 75)
            {
                PasswordStrengh.Foreground = Brushes.Green;
            }
        }


        public string TableValues(int i)
        {
            try
            {
                DataGridCellInfo cellInfo = tblProduct.SelectedCells[i];
                DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
                FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
                BindingOperations.SetBinding(element, TagProperty, column.Binding);

                return (element.Tag.ToString());
            }
            catch (ArgumentOutOfRangeException)
            {
                ACTMessages message = new ACTMessages(user, "eBuy", "Por favor, selecione um produto.", 3);
                message.ShowDialog();
            }

            return null;

        }

        public void LoadScreen(TOUser i, bool status)
        {
            //loads the quick menu.
            LoadMenu();

            //loads the table.
            tblProduct.AutoGenerateColumns = false;
            tblProduct.ItemsSource = DAOProd.LoadProduct(i,status);
            lblCount.Content = tblProduct.Items.Count;
            if(status == false)
            {
                tblProduct.Columns[6].Visibility = Visibility.Hidden;
            }
            else
            {
                tblProduct.Columns[6].Visibility = Visibility.Visible;
            }           
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            View.ACTProductRegistration productRegistration = new ACTProductRegistration(user);
            productRegistration.ShowDialog();
            user = productRegistration.ReturnUser;
            LoadScreen(user, status);
        }

        private void tblProduct_Loaded(object sender, RoutedEventArgs e)
        {
            LoadScreen(user, false);
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if(TableValues(1) != null)
            {
                TOProduct product = new TOProduct();
                product = DAOProd.Selection(TableValues(1));
                ACTProductRegistration pr = new ACTProductRegistration(user, product);
                pr.ShowDialog();
                user = pr.ReturnUser;
                LoadScreen(user, status);
            }
        }

        private void tblProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TableValues(1) != null)
            {
                TOProduct product = new TOProduct();
                product = DAOProd.Selection(TableValues(1));
                ACTProductRegistration pr = new ACTProductRegistration(user, product);
                pr.ShowDialog();
            }
            LoadScreen(user, status);
        }


        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (TableValues(1) != null)
            {
                MessageBoxResult result = MessageBox.Show("Você tem certeza de que gostaria de excluir este produto?",
               "Warning!", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    DAOProd.DeleteProduct(TableValues(1), user);
                }
                else
                {
                    //Do nothing.
                }
            }
            else
            {
            }
            LoadScreen(user, status);
        }

        private void btnWishList_Click(object sender, RoutedEventArgs e)
        {
            status = false;
            LoadScreen(user, status);
            lblTitle.Content = "Meu Carrinho";
            lblRegisters.Content = "Registros na sua lista de desejos:";
        }

        private void btnBoughtList_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            LoadScreen(user, status);
            lblTitle.Content = "Comprados";
            lblRegisters.Content = "Registros na sua lista de compras:";
        }

        private void txtTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            Model.DAO.DAOProduct p = new Model.DAO.DAOProduct();
            tblProduct.ItemsSource = p.Search(user, status, "product_name", txtTitle.Text.ToString());
        }

        private void txtType_TextChanged(object sender, TextChangedEventArgs e)
        {
            Model.DAO.DAOProduct p = new Model.DAO.DAOProduct();
            tblProduct.ItemsSource = p.Search(user, status, "product_type", txtType.Text.ToString());
        }

        private void txtStore_TextChanged(object sender, TextChangedEventArgs e)
        {
            Model.DAO.DAOProduct p = new Model.DAO.DAOProduct();
            tblProduct.ItemsSource = p.Search(user, status, "product_store", txtStore.Text.ToString());
        }

        private void txtPriceLow_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPriceLow.Text.ToString() == "")
            {
                if(txtPriceHigh.Text.ToString() != "")
                {
                    Model.DAO.DAOProduct p = new Model.DAO.DAOProduct();
                    tblProduct.ItemsSource = p.SearchPrice(user, status, Double.Parse(txtPriceHigh.Text.ToString()), Double.Parse(txtPriceHigh.Text.ToString()));
                }
                LoadScreen(user, status);
            }
            else if (txtPriceHigh.Text.ToString() == "")
            {
                if(txtPriceLow.Text.ToString() != "")
                {
                    Model.DAO.DAOProduct p = new Model.DAO.DAOProduct();
                    tblProduct.ItemsSource = p.SearchPrice(user, status, Double.Parse(txtPriceLow.Text.ToString()), Double.Parse(txtPriceLow.Text.ToString()));
                }
                LoadScreen(user, status);
            }
            else
            {
                Model.DAO.DAOProduct p = new Model.DAO.DAOProduct();
                tblProduct.ItemsSource = p.SearchPrice(user, status, Double.Parse(txtPriceLow.Text.ToString()), Double.Parse(txtPriceHigh.Text.ToString()));
            }
        }

        private void txtPriceHigh_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtPriceLow.Text.ToString() == "")
            {
                LoadScreen(user, status);
            }
            else if (txtPriceHigh.Text.ToString() == "")
            {
                LoadScreen(user, status);
            }
            else
            {
                Model.DAO.DAOProduct p = new Model.DAO.DAOProduct();
                tblProduct.ItemsSource = p.SearchPrice(user, status, Double.Parse(txtPriceLow.Text.ToString()), Double.Parse(txtPriceHigh.Text.ToString()));
            }
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if(Canvas.Visibility == Visibility.Visible)
            {
                Canvas.Visibility = Visibility.Hidden;
                Configuration.Visibility = Visibility.Hidden;
                CanvasInfo.Visibility = Visibility.Hidden;
            }
            else
            {
                Canvas.Visibility = Visibility.Visible;
            }
        }

        private void lblEdit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Configuration.Visibility == Visibility.Visible)
            {
                Configuration.Visibility = Visibility.Hidden;
                CanvasInfo.Visibility = Visibility.Hidden;
                imgArrowInfo.Visibility = Visibility.Hidden;
            }
            else
            {
                Configuration.Visibility = Visibility.Visible;
                imgArrowInfo.Visibility = Visibility.Hidden;
            }
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            imgArrowRecords.Visibility = Visibility.Hidden;
            imgArrowInfo.Visibility = Visibility.Visible;
            CanvasInfo.Visibility = Visibility.Visible;

            //the account will always be avaliable 'cause it's this account's name.
            //only get's red if the user changes it to another user's account.
            txtAccount.BorderBrush = Brushes.Green;

        }

        private void btnRecords_Click(object sender, RoutedEventArgs e)
        {
            imgArrowInfo.Visibility = Visibility.Hidden;
            imgArrowRecords.Visibility = Visibility.Visible;
            CanvasInfo.Visibility = Visibility.Hidden;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if(count == 1)
            {
                btnUpdate.Content = "Atualizar";
                txtAccount.IsEnabled = true;
                txtName.IsEnabled = true;
                txtSirName.IsEnabled = true;
                txtEmail.IsEnabled = true;
                txtAddCapital.IsEnabled = true;
                txtRemoveCapital.IsEnabled = true;
                psbNewPassword.IsEnabled = true;
                psbConfirmNewPassword.IsEnabled = true;
                count = 2;
            }
            else
            {
                user.Account = txtAccount.Text.ToString();
                if (DAOUser.VerifyAccountName(user.Account))
                {
                    txtAccount.BorderBrush = Brushes.Red;
                }
                else
                {
                    txtAccount.BorderBrush = Brushes.Green;

                    string stg = lblUserName.Content.ToString();

                    user = DAOUser.Update(user);

                        ACTMessages message = new ACTMessages(user, "eBuy", "Conta azualizada com sucesso.", 1);
                        message.ShowDialog();
                        txtName.Text = user.Name;
                        txtAccount.Text = user.Account;
                        txtSirName.Text = user.SirName;
                        txtEmail.Text = user.Email;
                        psbCurrentPassword.Password = user.Password;
                        psbNewPassword.Password = "";
                        psbConfirmNewPassword.Password = "";
                        txtCurrentCapital.Text = user.Credit.ToString();
                        txtTotalSpentCapital.Text = user.CreditSpent.ToString();

                        lblUserName.Content = user.Name + " " + user.SirName;
                        lblEmail.Content = user.Email;

                        if (ver == txtAccount.Text.ToString())
                        {

                        }
                        else
                        {
                            File.Copy(@"C:\eBuy\" + ver + ".png", @"C:\eBuy\" + user.Account + ".png", true);
                            File.Delete(@"C:\eBuy\" + ver + ".png");
                        }

                    count = 1;
                    btnUpdate.Content = "Editar";
                    txtAccount.IsEnabled = false;
                    txtName.IsEnabled = false;
                    txtSirName.IsEnabled = false;
                    txtEmail.IsEnabled = false;
                    txtAddCapital.IsEnabled = false;
                    txtRemoveCapital.IsEnabled = false;
                    psbNewPassword.IsEnabled = false;
                    psbCurrentPassword.IsEnabled = false;
                    psbConfirmNewPassword.IsEnabled = false;

                    //txtAddCapital.Text = "";
                    //txtRemoveCapital.Text = "";

                }
            }
            LoadScreen(user, status);
        }

        private void psbNewPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            user.Password = psbNewPassword.Password.ToString();
            PasswordStrengh.Value = (user.verifyPassword(psbNewPassword.Password));
            if (PasswordStrengh.Value <= 25)
            {
                PasswordStrengh.Foreground = Brushes.Red;
            }
            else if (PasswordStrengh.Value <= 50)
            {
                PasswordStrengh.Foreground = Brushes.Yellow;
            }
            else if (PasswordStrengh.Value >= 75)
            {
                PasswordStrengh.Foreground = Brushes.Green;
            }
            if (psbNewPassword.Password == psbConfirmNewPassword.Password)
            {
                psbNewPassword.BorderBrush = Brushes.Green;
                psbConfirmNewPassword.BorderBrush = Brushes.Green;
            }
            else
            {
                psbNewPassword.BorderBrush = Brushes.Red;
                psbConfirmNewPassword.BorderBrush = Brushes.Red;
            }

            if (psbNewPassword.Password == "" && psbConfirmNewPassword.Password == "")
            {
                psbConfirmNewPassword.BorderBrush = Brushes.White;
                psbNewPassword.BorderBrush = Brushes.White;
            }
        }

        private void psbConfirmNewPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            user.Password = psbNewPassword.Password.ToString();
            PasswordStrengh.Value = (user.verifyPassword(psbNewPassword.Password));
            if (PasswordStrengh.Value <= 25)
            {
                PasswordStrengh.Foreground = Brushes.Red;
            }
            else if (PasswordStrengh.Value <= 50)
            {
                PasswordStrengh.Foreground = Brushes.Yellow;
            }
            else if (PasswordStrengh.Value >= 75)
            {
                PasswordStrengh.Foreground = Brushes.Green;
            }
            if (psbNewPassword.Password == psbConfirmNewPassword.Password)
            {
                psbNewPassword.BorderBrush = Brushes.Green;
                psbConfirmNewPassword.BorderBrush = Brushes.Green;
            }
            else
            {
                psbNewPassword.BorderBrush = Brushes.Red;
                psbConfirmNewPassword.BorderBrush = Brushes.Red;
            }

            if (psbNewPassword.Password == "" && psbConfirmNewPassword.Password == "")
            {
                psbConfirmNewPassword.BorderBrush = Brushes.White;
                psbNewPassword.BorderBrush = Brushes.White;
            }
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            user.Name = txtName.Text.ToString();
        }

        private void txtSirName_TextChanged(object sender, TextChangedEventArgs e)
        {
            user.SirName = txtSirName.Text.ToString();
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            user.Email = txtEmail.Text.ToString();
            if (user.IsValidEmail(txtEmail.Text.ToString()))
            {
                txtEmail.BorderBrush = Brushes.Green;
            }
            else
            {
                txtEmail.BorderBrush = Brushes.Red;
            }
        }

        private void btnShowPassword_Click(object sender, RoutedEventArgs e)
        {
            psbCurrentPassword.Visibility = Visibility.Hidden;
            txtPassword.Visibility = Visibility.Visible;
            btnHidePassword.Visibility = Visibility.Visible;
            btnShowPassword.Visibility = Visibility.Hidden;
        }

        private void btnHidePassword_Click(object sender, RoutedEventArgs e)
        {
            psbCurrentPassword.Visibility = Visibility.Visible;
            txtPassword.Visibility = Visibility.Hidden;
            btnShowPassword.Visibility = Visibility.Visible;
            btnHidePassword.Visibility = Visibility.Hidden;

        }

        private void btnChangePic_Click(object sender, RoutedEventArgs e)
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
                File.Delete(@"C:\eBuy\" + user.Account + ".png");
                File.Copy(selection.FileName, @"C:\eBuy\" + user.Account + ".png", true);
            }
            else
            {
                File.Delete(@"C:\eBuy\" + user.Account + ".png");
                File.Copy(selection.FileName, @"C:\eBuy\" + user.Account + ".png", true);
            }

        }

        private void btnViewTransactions_Click(object sender, RoutedEventArgs e)
        {
            Configuration.Visibility = Visibility.Visible;
            imgArrowRecords.Visibility = Visibility;
            CanvasInfo.Visibility = Visibility.Hidden;
        }

        private void lblCapital_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Search.Visibility == Visibility.Visible)
            {
                Search.Visibility = Visibility.Hidden;
            }
            else
            {
                Search.Visibility = Visibility.Visible;
            }
        }

        private void lblRecentTitle_1_MouseDown(object sender, MouseButtonEventArgs e)
        {
                TOProduct product = new TOProduct();
                product = DAOProd.Selection(lblRecentTitle_1.Content.ToString());
                ACTProductRegistration pr = new ACTProductRegistration(user, product);
                pr.ShowDialog();
                LoadScreen(user, status);
        }

        private void lblRecentTitle_2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TOProduct product = new TOProduct();
            product = DAOProd.Selection(lblRecentTitle_2.Content.ToString());
            ACTProductRegistration pr = new ACTProductRegistration(user, product);
            pr.ShowDialog();
            LoadScreen(user, status);

        }

        private void lblRecentTitle_3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TOProduct product = new TOProduct();
            product = DAOProd.Selection(lblRecentTitle_3.Content.ToString());
            ACTProductRegistration pr = new ACTProductRegistration(user, product);
            pr.ShowDialog();
            LoadScreen(user, status);

        }

        private void txtAddCapital_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtAddCapital.Text.ToString() == "")
            {

            }else
            {
                user.Credit = user.Credit + Double.Parse(txtAddCapital.Text.ToString());
                user.CreditAvaliable = user.CreditAvaliable + Double.Parse(txtAddCapital.Text.ToString());
            }
        }

        private void txtRemoveCapital_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtRemoveCapital.Text.ToString() == "")
            {

            }
            else
            {
                user.Credit = user.Credit - Double.Parse(txtRemoveCapital.Text.ToString());
                user.CreditAvaliable = user.CreditAvaliable - Double.Parse(txtRemoveCapital.Text.ToString());
            }
        }
    }
}
