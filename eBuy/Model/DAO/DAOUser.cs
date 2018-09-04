using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace eBuy.Model.DAO
{
    class DAOUser
    {

        public TOUser Login(string account, string password)
        {
            MySqlConnection con = null;

            TOUser i = new TOUser();

            try
            {
                string sql = "select * from tbl_user where user_account = '" + account + "' and  user_password = '" + password + "';";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                if (dtreader.Read())//If there's any data.
                {
                    i.Id = dtreader.GetInt16("user_id");
                    i.Name = dtreader.GetString("user_name");
                    i.SirName = dtreader.GetString("user_sirName");
                    i.Account = dtreader.GetString("user_account");
                    i.House = dtreader.GetInt16("house_id");
                    i.Password = dtreader.GetString("user_password");
                    i.Email = dtreader.GetString("user_email");
                    i.Credit = dtreader.GetDouble("user_credit");
                    i.CreditSpent = dtreader.GetDouble("user_creditSpent");
                    i.CreditAvaliable = dtreader.GetDouble("user_creditAvaliable");
                }
                else
                {
                }

            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return i;
        }

        public TOUser Selection(int id)
        {
            MySqlConnection con = null;

            TOUser i = new TOUser();

            try
            {
                string sql = "select * from tbl_user where user_id = " + id + ";";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                if (dtreader.Read())//If there's any data.
                {
                    i.Id = dtreader.GetInt16("user_id");
                    i.Name = dtreader.GetString("user_name");
                    i.SirName = dtreader.GetString("user_sirName");
                    i.Account = dtreader.GetString("user_account");
                    i.House = dtreader.GetInt16("house_id");
                    i.Password = dtreader.GetString("user_password");
                    i.Email = dtreader.GetString("user_email");
                    i.Credit = dtreader.GetDouble("user_credit");
                    i.CreditSpent = dtreader.GetDouble("user_creditSpent");
                    i.CreditAvaliable = dtreader.GetDouble("user_creditAvaliable");
                }
                else
                {
                }

            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return i;
        }

        public TOUser Update(TOUser user)
        {
            MySqlConnection con = null;

            TOUser i = new TOUser();

            try
            {
                string sql = @"update tbl_user set user_name = '" + user.Name + "', user_sirName = '" + user.SirName + "', user_account = '" + user.Account + 
                    "', user_password = '" + user.Password + "', user_email = '" + user.Email + "', user_credit = " + user.Credit + ", user_creditSpent = " + user.CreditSpent +
                    ", user_creditAvaliable = " + user.CreditAvaliable + " where user_id = " + user.Id + ";";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();

                string select = "select * from tbl_user where user_id = " + user.Id + ";";

                MySqlCommand command = new MySqlCommand(select, con);
                
                MySqlDataReader dtreader = command.ExecuteReader();

                if (dtreader.Read())//If there's any data.
                {
                    i.Id = dtreader.GetInt16("user_id");
                    i.Name = dtreader.GetString("user_name");
                    i.SirName = dtreader.GetString("user_sirName");
                    i.Account = dtreader.GetString("user_account");
                    i.House = dtreader.GetInt16("house_id");
                    i.Password = dtreader.GetString("user_password");
                    i.Email = dtreader.GetString("user_email");
                    i.Credit = dtreader.GetDouble("user_credit");
                    i.CreditSpent = dtreader.GetDouble("user_creditSpent");
                    i.CreditAvaliable = dtreader.GetDouble("user_creditAvaliable");
                }
                else
                {
                }

            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return i;
        }

        public TOUser TotalCredit(TOUser i)
        {
            TOUser user = new TOUser();

            MySqlConnection con = null;

            try
            {
                string sql = "update tbl_user set user_creditAvaliable = user_credit - user_creditSpent where user_id = " + i.Id + ";";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                string select = "select * from tbl_user where user_id = " + i.Id + ";";

                MySqlCommand comando = new MySqlCommand (select, con);

                con.Open();

                MySqlDataReader dtreader = comando.ExecuteReader();

                if (dtreader.Read())
                {
                    user.Id = dtreader.GetInt16("user_id");
                    user.Name = dtreader.GetString("user_name");
                    user.SirName = dtreader.GetString("user_sirName");
                    user.Account = dtreader.GetString("user_account");
                    user.House = dtreader.GetInt16("house_id");
                    user.Password = dtreader.GetString("user_password");
                    user.Email = dtreader.GetString("user_email");
                    user.Credit = dtreader.GetDouble("user_credit");
                    user.CreditSpent = dtreader.GetDouble("user_creditSpent");
                    user.CreditAvaliable = dtreader.GetDouble("user_creditAvaliable");
                }

            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return user;
        }

        public TOUser CreditSpent(TOUser i, double value)
        {
            TOUser user = new TOUser();

            MySqlConnection con = null;

            try
            {
                string sql = "update tbl_user set user_creditSpent = user_creditSpent + " + value + " where user_id = " + i.Id + ";";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                string select = "select * from tbl_user where user_id = " + i.Id + ";";

                MySqlCommand comando = new MySqlCommand(select, con);

                con.Open();

                MySqlDataReader dtreader = comando.ExecuteReader();

                if (dtreader.Read())
                {
                    user.Id = dtreader.GetInt16("user_id");
                    user.Name = dtreader.GetString("user_name");
                    user.SirName = dtreader.GetString("user_sirName");
                    user.Account = dtreader.GetString("user_account");
                    user.House = dtreader.GetInt16("house_id");
                    user.Password = dtreader.GetString("user_password");
                    user.Email = dtreader.GetString("user_email");
                    user.Credit = dtreader.GetDouble("user_credit");
                    user.CreditSpent = dtreader.GetDouble("user_creditSpent");
                    user.CreditAvaliable = dtreader.GetDouble("user_creditAvaliable");

                }

            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return user;
        }

        public bool Registration(TOUser user)
        {
            MySqlConnection con = null;

            bool i = false;

            try
            {
                    string sql = "insert into tbl_user(user_name, user_sirName, user_account, user_password, user_email, user_credit, user_creditSpent, user_creditAvaliable, house_id) values('" + user.Name + "', '" + user.SirName + "', '" + user.Account +"', '" + user.Password + "', '" + user.Email + "', " + user.Credit + ", 0, " + user.CreditAvaliable + ", 0)";

                    con = ConnectionFactory.Connection();

                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();

                    string select = "select * from tbl_user where user_account = '" + user.Account + "';";

                    con.Open();

                    MySqlCommand command = new MySqlCommand(select, con);

                    MySqlDataReader dtreader = command.ExecuteReader();

                    if (dtreader.Read())//If there's any data.
                    {
                        //registration sucessful
                        i = true;
                    }             
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return i;
        }

        public bool VerifyAccountName(string account)
        {
            MySqlConnection con = null;

            bool i = false;

            try
            {
                string verification = "select * from tbl_user where user_account = '" + account + "';";

                con = ConnectionFactory.Connection();

                MySqlCommand verificationCMD = new MySqlCommand(verification, con);

                con.Open();

                MySqlDataReader reader = verificationCMD.ExecuteReader();

                if (reader.Read())
                {
                    //code for existing account.
                    i = true;
                }
                else
                {

                }
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return i;
    }

        public bool VerifyAccountEmail(string email)
        {
            MySqlConnection con = null;

            bool i = false;

            try
            {
                string verification = "select * from tbl_user where user_email = '" + email + "';";

                con = ConnectionFactory.Connection();

                MySqlCommand verificationCMD = new MySqlCommand(verification, con);

                con.Open();

                MySqlDataReader reader = verificationCMD.ExecuteReader();

                if (reader.Read())
                {
                    //code for existing email.
                    i = true;
                }
                else
                {

                }
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return i;
        }

        public bool HouseSelection(TOUser user, int house)
        {
            MySqlConnection con = null;

            bool i = false;

            try
            {
                string sql = "update tbl_user set house_id = " + house +  " where user_account = '" + user.Account + "';";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                string select = "select house_id from tbl_user where user_account = '" + user.Account + "';";

                con.Open();

                MySqlCommand command = new MySqlCommand(select, con);

                MySqlDataReader dtreader = command.ExecuteReader();

                if (dtreader.Read())//If there's any data.
                {
                    user.House = dtreader.GetInt16("house_id");
                    if(user.House == house)
                    {
                        i = true;
                    }
                }
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                con.Close();
            }
            return i;
        }

    }
}
