using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBuy.Model.DAO
{
    class DAOProduct
    {
        MySqlConnection con = null;

        public bool Registration(TOProduct product, TOUser user)
        {

            bool i = false;

            try
            {
                string sql = @"insert into tbl_product(product_name, product_status, product_type, product_description, product_link, product_store, product_price, product_buyingDate, user_id, priority_id) values(
                    '" + product.Name + "', " + product.Status + ", '" + product.Type + "', '" + product.Description + "', '" + product.Link + "', '" + product.Store + "', " + product.Price + ", '" + product.BuyingDate + "', "
                    + user.Id + ", " + product.Priority + ");";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                string select = "select * from tbl_product where product_name = '" + product.Name + "';";

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

        public List<TOProduct> LoadProduct(TOUser user, bool status)
        {
            List<TOProduct> i = new List<TOProduct>();
            try
            {
                

                string sql = "select * from tbl_product where user_id = " + user.Id + " and product_status = " + status + ";";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                if(status == true)
                {
                    while (dtreader.Read())//If there's any data.
                    {
                        TOProduct x = new TOProduct();

                        x.Id = dtreader.GetInt16("product_id");
                        x.Link = dtreader.GetString("product_link");
                        x.Name = dtreader.GetString("product_name");
                        x.Type = dtreader.GetString("product_type");
                        x.Price = dtreader.GetDouble("product_price");
                        x.Store = dtreader.GetString("product_store");
                        x.BuyingDate = dtreader.GetDateTime("product_buyingDate").ToString("dd-MM-yyyy"); ;

                        i.Add(x);

                    }

                    con.Close();


                }
                else
                {
                    while (dtreader.Read())//If there's any data.
                    {
                        TOProduct x = new TOProduct();

                        x.Id = dtreader.GetInt16("product_id");
                        x.Link = dtreader.GetString("product_link");
                        x.Name = dtreader.GetString("product_name");
                        x.Type = dtreader.GetString("product_type");
                        x.Price = dtreader.GetDouble("product_price");
                        x.Store = dtreader.GetString("product_store");

                        i.Add(x);

                    }

                    con.Close();


                }
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }

            return i;
        }

        public TOProduct LoadRecent(TOUser user, int recent)
        {
            TOProduct i = new TOProduct();

            try
            {


                string sql = "select * from tbl_product where product_id = (select (max(product_id)-" + recent + ") from tbl_product) and product_status = true;";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                    while (dtreader.Read())//If there's any data.
                    {
                        i.Id = dtreader.GetInt16("product_id");
                        i.Link = dtreader.GetString("product_link");
                        i.Name = dtreader.GetString("product_name");
                        i.Type = dtreader.GetString("product_type");
                        i.Price = dtreader.GetDouble("product_price");
                        i.Store = dtreader.GetString("product_store");
                        i.BuyingDate = dtreader.GetDateTime("product_buyingDate").ToString("dd-MM-yyyy");

                    }
                    con.Close();
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }

            return i;
        }

        public TOProduct Selection(string product)
        {
            TOProduct i = new TOProduct();
            try
            {
                MySqlConnection con = null;

                string sql = "select * from tbl_product where product_name = '" + product + "';";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                while (dtreader.Read())//If there's any data.
                {
                    i.Id = dtreader.GetInt16("product_id");
                    i.Link = dtreader.GetString("product_link");
                    i.Name = dtreader.GetString("product_name");
                    i.Type = dtreader.GetString("product_type");
                    i.Price = dtreader.GetDouble("product_price");
                    i.Priority = dtreader.GetInt16("priority_id");
                    i.Status = dtreader.GetBoolean("product_status");
                    i.Store = dtreader.GetString("product_store");

                }

                con.Close();

            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }

            return i;
        }

        public bool DeleteProduct(string product, TOUser user)
        {
            bool i = false;
            try
            {
                string sql = "delete from tbl_product where product_name = '" + product + "' and user_id = " + user.Id + ";";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader dtreader = cmd.ExecuteReader();

                if (dtreader.Read())
                {
                    i = false;
                }
                else
                {
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

        public bool Update(TOProduct product, TOUser user)
        {

            bool i = false;

            try
            {
                string sql = @"update tbl_product set product_id = " +product.Id + ", product_name = '" + product.Name + "', product_status = " + product.Status + ", product_type = '" + product.Type + "', product_description = '', product_link = '" + product.Link + "', product_store = '" + product.Store + "', product_price = " + product.Price + ", user_id = " + user.Id + ", priority_id = " + product.Priority + " where product_id = " + product.Id + ";";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                string select = "select * from tbl_product where product_id = '" + product.Id + "';";

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

        public bool UpdateDate(TOProduct product, string date)
        {

            bool i = false;

            try
            {
                string sql = @"update tbl_product set product_buyingDate = (REPLACE('" + date + "', '/', '-')) where product_id = " + product.Id + ";";

                con = ConnectionFactory.Connection();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

                string select = "select * from tbl_product where product_id = '" + product.Id + "';";

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

        public List<TOProduct> Search(TOUser user, bool status, string field, string parameter)
        {
            List<TOProduct> i = new List<TOProduct>();

            string sql = @"select * from tbl_product 
            where user_id = " + user.Id + " and product_status = " + status + " and " + field + " like '" + parameter + "%';";

            try
            {
                con = ConnectionFactory.Connection();

                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader dtreader = cmd.ExecuteReader();

                while (dtreader.Read())
                {
                    TOProduct p = new TOProduct();

                    p.Id = dtreader.GetInt16("product_id");
                    p.Type = dtreader.GetString("product_type");
                    p.Name = dtreader.GetString("product_name");
                    p.Link = dtreader.GetString("product_link");
                    p.Store = dtreader.GetString("product_store");
                    p.Price = dtreader.GetDouble("product_price");
                    p.BuyingDate = dtreader.GetDateTime("product_buyingDate").ToString("dd-MM-yyyy") ;

                    i.Add(p);
                }
                con.Close();
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return i;

        }

        public List<TOProduct> SearchPrice(TOUser user, bool status, double lowPrice, double highPrice)
        {
            List<TOProduct> i = new List<TOProduct>();

            string sql = @"select * from tbl_product 
            where user_id = " + user.Id + " and product_status = " + status + " and product_price between " + lowPrice + " and " + highPrice + ";";

            try
            {
                con = ConnectionFactory.Connection();

                con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader dtreader = cmd.ExecuteReader();

                while (dtreader.Read())
                {
                    TOProduct p = new TOProduct();

                    p.Id = dtreader.GetInt16("product_id");
                    p.Type = dtreader.GetString("product_type");
                    p.Name = dtreader.GetString("product_name");
                    p.Link = dtreader.GetString("product_link");
                    p.Store = dtreader.GetString("product_store");
                    p.Price = dtreader.GetDouble("product_price");
                    p.BuyingDate = dtreader.GetDateTime("product_buyingDate").ToString("dd-MM-yyyy");

                    i.Add(p);
                }
                con.Close();
            }
            catch (MySqlException e)
            {
                throw new Exception(e.Message);
            }
            return i;

        }


    }
}
