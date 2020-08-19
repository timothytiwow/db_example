using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectDatabse
{
    public class DBConnect
    {
        MySqlConnection sqlConnection;
        string server;
        string database;
        string uid;
        string password;

        public DBConnect(string username, string password)
        {
            server = "localhost";
            database = "hello";
            this.uid = username;
            this.password = password;
        }

        public bool Initialize()
        {
            string connectString = $"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password}";

            sqlConnection = new MySqlConnection(connectString);
            if(OpenConnection())
            {
                CloseConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                //switch (e.Number)
                //{
                //    case 0:
                //        MessageBox.Show("Cannot connect to server.");
                //        break;
                //    case 1045:
                //        MessageBox.Show("Login failed.");
                //        break;
                //}
                MessageBox.Show(e.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                sqlConnection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public void Insert(string name, int age)
        {
            string query = $"INSERT INTO mytable VALUES(\"{name}\", {age})";

            if (this.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete(string name, int age)
        {
            string query = $"DELETE FROM mytable WHERE name=\"{name}\" AND age={age}";

            if (this.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                command.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public List<string>[] Select()
        {
            string query = $"SELECT * from mytable";

            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();

            if (this.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                MySqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    list[0].Add(dataReader["name"].ToString());
                    list[1].Add(dataReader["age"].ToString());
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

        public int Count()
        {
            string query = $"SELECT Count(*) FROM mytable";
            int Count = -1;

            if(this.OpenConnection() == true)
            {
                MySqlCommand command = new MySqlCommand(query, sqlConnection);
                Count = int.Parse(command.ExecuteScalar().ToString());
                this.CloseConnection();
                return Count;
            }
            else
            {
                return Count;
            }
        }

        public void Backup()
        {
            throw new NotImplementedException();
        }

        public void Restore()
        {
            throw new NotImplementedException();
        }
    }
}
