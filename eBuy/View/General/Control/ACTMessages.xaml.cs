using eBuy.Model;
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

namespace eBuy.View.General.Control
{
    public partial class ACTMessages : Window
    {
        public ACTMessages(TOUser TOUser, string title, string message, int type)
        {
            InitializeComponent();
            lblTitle.Content = title;
            lblMessage.Content = message;
            if(type == 1)
            {
                imgSucess.Visibility = Visibility.Visible;
            }else if(type == 2)
            {
                imgInformation.Visibility = Visibility.Visible;
            }else if(type == 3)
            {
                imgError.Visibility = Visibility.Visible;
            }

            if (TOUser.House == 1) {
                //background
                var a = new SolidColorBrush(Color.FromArgb(255, 212, 64, 64));
                this.Background = a;

                //label
                var b = new SolidColorBrush(Color.FromArgb(255, 255, 209, 1));
                lblColor.Background = b;

                //hermione.
                img1.Visibility = Visibility.Visible;
            }
            else if(TOUser.House == 2)
            {
                //background
                var a = new SolidColorBrush(Color.FromArgb(255, 200, 200, 200));
                this.Background = a;

                //label
                var b = new SolidColorBrush(Color.FromArgb(255, 12, 63, 6));
                lblColor.Background = b;

                //hermione.
                img2.Visibility = Visibility.Visible;

            }
            else if(TOUser.House == 3)
            {
                //background
                var a = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                this.Background = a;

                //label
                var b = new SolidColorBrush(Color.FromArgb(255, 255, 243, 0));
                lblColor.Background = b;

                //hermione.
                img3.Visibility = Visibility.Visible;

            }
            else if(TOUser.House == 4)
            {
                //background
                var a = new SolidColorBrush(Color.FromArgb(255, 200, 200, 200));
                this.Background = a;

                //label
                var b = new SolidColorBrush(Color.FromArgb(255, 6, 9, 64));
                lblColor.Background = b;

                //hermione.
                img4.Visibility = Visibility.Visible;
            }
            else
            {
                //background
                var a = new SolidColorBrush(Color.FromArgb(255, 58, 58, 60));
                this.Background = a;

                //label
                var b = new SolidColorBrush(Color.FromArgb(255, 58, 58, 60));
                lblColor.Background = b;
            }
        }   

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
