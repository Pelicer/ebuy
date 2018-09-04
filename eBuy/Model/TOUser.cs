using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace eBuy.Model
{
    public class TOUser
    {

        int id;
        int house;
        string name;
        string sirName;
        string account;
        string password;
        string email;
        double credit;
        double creditSpent;
        double creditAvaliable;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int House
        {
            get
            {
                return house;
            }

            set
            {
                house = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string SirName
        {
            get
            {
                return sirName;
            }

            set
            {
                sirName = value;
            }
        }

        public string Account
        {
            get
            {
                return account;
            }

            set
            {
                account = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public double Credit
        {
            get
            {
                return credit;
            }

            set
            {
                credit = value;
            }
        }

        public double CreditSpent
        {
            get
            {
                return creditSpent;
            }

            set
            {
                creditSpent = value;
            }
        }

        public double CreditAvaliable
        {
            get
            {
                return creditAvaliable;
            }

            set
            {
                creditAvaliable = value;
            }
        }

        public int verifyPassword(string password)
        {
            int strength = 0;

            if (password.Length < 1)
            {
                strength = 0;
            }
            else if (password.Length <= 4)
            {
                strength = 15;
            }
            else if (password.Length <= 8)
            {
                strength = 45;
            }

            var specialCharacter = new Regex(@"[@\\*+!$%&.,-_123456789]+");

            if (password.Length > 8 && specialCharacter.IsMatch(password))
            {
                strength = 100;
            }
            else if(password.Length > 8)
            {
                strength = 80;
            }          
            return strength;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var adress = new System.Net.Mail.MailAddress(email);
                return adress.Address == email;
            }
            catch
            {
                return false;
            }
        }       
    }
}
