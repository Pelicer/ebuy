using eBuy.Model;
using eBuy.View.General.Control;
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

namespace eBuy.View.User.Registration
{
    public partial class ACTHouseSelection : Window
    {
        TOUser TOUser = new TOUser();
        Model.DAO.DAOUser uDAO = new Model.DAO.DAOUser();

        public ACTHouseSelection(TOUser user)
        {
            TOUser = user;
            InitializeComponent();
        }


        private void imgS_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TOUser.House = 2;
            uDAO.HouseSelection(TOUser, TOUser.House);
            ACTMessages message = new ACTMessages(TOUser, "eBuy", "Bem vindo à Sonserina!", 2);
            message.ShowDialog();
            this.Close();
        }

        private void imgG_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TOUser.House = 1;
            uDAO.HouseSelection(TOUser, TOUser.House);
            ACTMessages message = new ACTMessages(TOUser, "eBuy", "Bem vindo à Grifinória!", 2);
            message.ShowDialog();
            this.Close();
        }

        private void imgH_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TOUser.House = 3;
            uDAO.HouseSelection(TOUser, TOUser.House);
            ACTMessages message = new ACTMessages(TOUser, "eBuy", "Bem vindo à Lufa-Lufa!", 2);
            message.ShowDialog();
            this.Close();
        }

        private void imgR_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TOUser.House = 4;
            uDAO.HouseSelection(TOUser, TOUser.House);
            ACTMessages message = new ACTMessages(TOUser, "eBuy", "Bem vindo à Corvinal!", 2);
            message.ShowDialog();
            this.Close();
        }

    }
}
