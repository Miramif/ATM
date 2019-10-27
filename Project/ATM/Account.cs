using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ATM
{
    struct Accountinfo
    {
        public int id;
        public string card_number;
        public byte bank_type;
        public string status;
        public string pin;
        public string owner_name;
        public string tel_number;
        public double balance;
    }
    class Account
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Accountinfo info;
        public Account()
        {
            Initialize();
        }
        private void Initialize()
        {
            server = "localhost";
            database = "atm";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void ResetAccount()
        {
            info.id = 0;
            info.card_number = "";
            info.bank_type = 0;
            info.status = "";
            info.pin = "";
            info.owner_name = "";
            info.tel_number = "";
            info.balance = 0;
         }
        public string CheckCardVerification(string card_number)
        {
            string query = "select * from account where card_number = '" + card_number + "'";
            List<string> status = new List<string>();
            string crd_status = "CNE";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    status.Add(dataReader["card_status"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                if (string.Join(",", status.ToArray()) == "ACT") crd_status = "ACT";
                else if (string.Join(",", status.ToArray()) == "EXP") crd_status = "EXP";
                else if (string.Join(",", status.ToArray()) == "BLK") crd_status = "BLK";
                return crd_status;
            }
            else return crd_status;
        }
        public bool CheckPinVerification(string card_number, string pin)
        {
            string query = "select * from account where card_number = '" + card_number + "'";
            List<string> status = new List<string>();
            bool pin_status = false;
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    status.Add(dataReader["pin"] + "");
                }
                dataReader.Close();
                this.CloseConnection();
                if (string.Join(",", status.ToArray()) == pin) pin_status = true;
                else pin_status = false;
                return pin_status;
            }
            else return pin_status;
        }
        public void Withdraw(string card_number, string new_balance, string old_balance)
        {
            string query = "update account set balance = '" + new_balance +
                "' where card_number = '" + card_number + "' and balance = '" + old_balance + "'";
          
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

        }
        public void ChangePin(string card_number, string new_pin, string old_pin)
        {
            string query = "update account set pin = '" + new_pin +
                "' where card_number = '" + card_number + "' and pin = '" + old_pin + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

        }
        public void BlockCard(string card_number)
        {
            string query = "update account set card_status = 'BLK' where card_number = '" + card_number + "'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }

        }
        public List<string>[] GetInfo(string card_number)
        {
            string query = "select * from account where card_number = '" + card_number + "'";

            List<string>[] list = new List<string>[8];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();
            list[5] = new List<string>();
            list[6] = new List<string>();
            list[7] = new List<string>();

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["card_number"] + "");
                    list[2].Add(dataReader["bank_type"] + "");
                    list[3].Add(dataReader["card_status"] + "");
                    list[4].Add(dataReader["pin"] + "");
                    list[5].Add(dataReader["owner_name"] + "");
                    list[6].Add(dataReader["tel_number"] + "");
                    list[7].Add(dataReader["balance"] + "");
                }

                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else
            {
                return list;
            }

        }
    }
}
