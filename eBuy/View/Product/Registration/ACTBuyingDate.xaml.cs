using eBuy.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace eBuy.View.Product.Registration
{
    public partial class ACTBuyingDate : Window
    {
        TOProduct p = new TOProduct();

        public ACTBuyingDate(TOProduct product)
        {
            InitializeComponent();
            p = product;
        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            string i = Convert.ToDateTime(DateChooser.SelectedDate).ToString("yyyy-MM-dd HH:mm:ss");

            Model.DAO.DAOProduct pDAO = new Model.DAO.DAOProduct();
            pDAO.UpdateDate(p, i);

            this.Close();
        }

        private void DateChooser_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            txtDate.Text = Convert.ToDateTime(DateChooser.SelectedDate).ToString("dd-MM-yyyy");
        }
    }
}
