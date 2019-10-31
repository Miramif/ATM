using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATM
{
    public class Account: IDisposable
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
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
         ~Account()
        {
            connection.Dispose();
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
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
                cmd.Dispose();
                crd_status = string.Join(",", status.ToArray());
                return crd_status;
            }
            else return crd_status;
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
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
                cmd.Dispose();
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
            ExecuteSql(query);

        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        private void ExecuteSql(string query)
        {
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
                cmd.Dispose();
            }
        }

        public void ChangePin(string card_number, string new_pin, string old_pin)
        {
            string query = "update account set pin = '" + new_pin +
                "' where card_number = '" + card_number + "' and pin = '" + old_pin + "'";
            ExecuteSql(query);

        }
        public void BlockCard(string card_number)
        {
            string query = "update account set card_status = 'BLK' where card_number = '" + card_number + "'";
            ExecuteSql(query);
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
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
                cmd.Dispose();
                return list;
            }
            else
            {
                return list;
            }
        }

        public void Dispose()
        {
            connection.Dispose();
            GC.SuppressFinalize(connection);
        }
    }
}
