using eBuy.Model;
using eBuy.View.General.Control;
using eBuy.View.Product.Registration;
using System;
using System.Collections.Generic;
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

namespace eBuy.View
{
    public partial class ACTProductRegistration : Window
    {
        int i = 1;
        int count = 1;
        TOProduct product = new TOProduct();
        TOUser user = new TOUser();

        public ACTProductRegistration(TOUser u)
        {
            InitializeComponent();
            user = u;
            btnEdit.Visibility = Visibility.Hidden;
        }

        public ACTProductRegistration(TOUser u, TOProduct p)
        {
            i = 2;
            product = p;
            //setting textboxes.
            InitializeComponent();
            user = u;
            txtLink.Text = p.Link;
            txtPrice.Text = p.Price.ToString();
            txtProduct.Text = p.Name;
            txtStore.Text = p.Store;
            txtType.Text = p.Type;
            
            //set comboboxes.
            if(product.Priority == 1)
            {
                cbxPriority.SelectedValue = "Muito baixa";

            }else if(product.Priority == 2)
            {
                cbxPriority.SelectedValue = "Baixa";

            }
            else if(product.Priority == 3)
            {
                cbxPriority.SelectedValue = "Normal";

            }
            else if(product.Priority == 4)
            {
                cbxPriority.SelectedValue = "Alta";

            }
            else if(product.Priority == 5)
            {
                cbxPriority.SelectedValue = "Muito Alta";

            }

            //setting radioButton.
            if(product.Status == true)
            {
                rdbComprado.IsChecked = true;
            }
            else
            {
                rdbListaDesejo.IsChecked = true;
            }

            //disabling all components.
            txtLink.IsEnabled = false;
            txtPrice.IsEnabled = false;
            txtProduct.IsEnabled = false;
            txtStore.IsEnabled = false;
            txtType.IsEnabled = false;
            cbxPriority.IsEnabled = false;
            rdbComprado.IsEnabled = false;
            rdbListaDesejo.IsEnabled = false;
            btnRegister.IsEnabled = false;
            btnEdit.Visibility = Visibility.Visible;

        }

        //returns the user back with the credit updated.
        public TOUser ReturnUser { get { return user; } }

        private void txtProduct_TextChanged(object sender, TextChangedEventArgs e)
        {
            product.Name = txtProduct.Text.ToString();
        }

        private void txtType_TextChanged(object sender, TextChangedEventArgs e)
        {
            product.Type = txtType.Text.ToString();
        }

        private void txtPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            product.Price = Double.Parse(txtPrice.Text.ToString());
        }

        private void txtStore_TextChanged(object sender, TextChangedEventArgs e)
        {
            product.Store = txtStore.Text.ToString();
        }

        private void txtLink_TextChanged(object sender, TextChangedEventArgs e)
        {
            product.Link = txtLink.Text.ToString();
        }

        private void Lowest_Selected(object sender, RoutedEventArgs e)
        {
            product.Priority = 1;
        }

        private void Low_Selected(object sender, RoutedEventArgs e)
        {
            product.Priority = 2;
        }

        private void Normal_Selected(object sender, RoutedEventArgs e)
        {
            product.Priority = 3;
        }

        private void High_Selected(object sender, RoutedEventArgs e)
        {
            product.Priority = 4;
        }

        private void Highest_Selected(object sender, RoutedEventArgs e)
        {
            product.Priority = 5;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rdbComprado_Checked(object sender, RoutedEventArgs e)
        {
            product.Status = true;
        }

        private void rdbListaDesejo_Checked(object sender, RoutedEventArgs e)
        {
            product.Status = false;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (i == 1)
            {

                if(rdbComprado.IsChecked == true)
                {

                    product.BuyingDate = "0000-00-00 00:00:00";

                    Model.DAO.DAOProduct d = new Model.DAO.DAOProduct();
                    if (d.Registration(product, user))
                    {
                        product =  d.Selection(txtProduct.Text.ToString());
                        ACTBuyingDate date = new ACTBuyingDate(product);
                        date.ShowDialog();

                        Model.DAO.DAOUser uDAO = new Model.DAO.DAOUser();

                        user = uDAO.CreditSpent(user, product.Price);
                        user = uDAO.TotalCredit(user);
                        user = uDAO.Update(user);

                        ACTMessages message = new ACTMessages(user, "eBuy", "Produto registrado com sucesso.", 1);
                        message.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        ACTMessages message = new ACTMessages(user, "eBuy", "Algo errado aconteceu. Por favor, tente novamente mais tarde.", 3);
                        message.ShowDialog();
                    }
                }
                else{

                    product.BuyingDate = "0000-00-00 00:00:00";

                    Model.DAO.DAOProduct d = new Model.DAO.DAOProduct();
                    if (d.Registration(product, user))
                    {
                        ACTMessages message = new ACTMessages(user, "eBuy", "Produto registrado com sucesso.", 1);
                        message.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        ACTMessages message = new ACTMessages(user, "eBuy", "Algo errado aconteceu. Por favor, tente novamente mais tarde.", 3);
                        message.ShowDialog();
                    }
                }

            }
            else
            {
                if(rdbComprado.IsChecked == true)
                {

                    ACTBuyingDate date = new ACTBuyingDate(product);
                    date.ShowDialog();
                    
                    Model.DAO.DAOProduct dPRO = new Model.DAO.DAOProduct();


                    if (dPRO.Update(product, user))
                    {

                        Model.DAO.DAOUser uDAO = new Model.DAO.DAOUser();
                        user = uDAO.CreditSpent(user, product.Price);
                        user = uDAO.TotalCredit(user);
                        user = uDAO.Update(user);


                        ACTMessages message = new ACTMessages(user, "eBuy", "Produto atualizado com sucesso.", 1);
                        message.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        ACTMessages message = new ACTMessages(user, "eBuy", "Algo errado aconteceu. Por favor, tente novamente mais tarde.", 3);
                        message.ShowDialog();
                    }

                }
                else
                {
                    Model.DAO.DAOProduct dPRO = new Model.DAO.DAOProduct();
                    if (dPRO.Update(product, user))
                    {

                        ACTMessages message = new ACTMessages(user, "eBuy", "Produto atualizado com sucesso.", 1);
                        message.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        ACTMessages message = new ACTMessages(user, "eBuy", "Algo errado aconteceu. Por favor, tente novamente mais tarde.", 3);
                        message.ShowDialog();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if(count == 1)
            {
                txtLink.IsEnabled = true;
                txtPrice.IsEnabled = true;
                txtProduct.IsEnabled = true;
                txtStore.IsEnabled = true;
                txtType.IsEnabled = true;
                cbxPriority.IsEnabled = true;
                rdbComprado.IsEnabled = true;
                rdbListaDesejo.IsEnabled = true;
                btnRegister.IsEnabled = true;
                count = 2;
            }
            else
            {
                txtLink.IsEnabled = false;
                txtPrice.IsEnabled = false;
                txtProduct.IsEnabled = false;
                txtStore.IsEnabled = false;
                txtType.IsEnabled = false;
                cbxPriority.IsEnabled = false;
                rdbComprado.IsEnabled = false;
                rdbListaDesejo.IsEnabled = false;
                btnRegister.IsEnabled = false;
                count = 1;

            }
        }
    }
}
