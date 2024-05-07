using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Web.Services.Description;

namespace WebInquerito
{
    public class DBConnect
    {
        private SQLiteConnection connection;
        
        public DBConnect() 
        {
            Initialize();
        }
        
        private void Initialize()
        {

            string connectionString;
            String path = AppDomain.CurrentDomain.BaseDirectory + "bin\\";
            connectionString = "Data Source ="+ path+ "inquerito.db; Version = 3 ";
            
            connection = new SQLiteConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                //MessageBox.Show(ex.Message);
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
            catch (SQLiteException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool Insert(string nome, string distrito, string comida, string clube) 
        {
            try 
            {
                string query = "Insert into dados (nome, distrito, comida, clube) values ('" + 
                    nome + "','" + distrito + "','" + comida + "','" + clube + "')"; 

                if (this.OpenConnection() == true) 
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }
                else 
                {
                    return false;
                }
            
            }
            catch (SQLiteException ex) 
            {
                return false;
            }
            return true;
        }

        public bool Update(string nome, string distrito, string comida, string clube)
        {
            string query = "update formando set nome = '" + nome + "', distrito = '" + distrito + "', comida = '" +
                comida + "' where id_formando = " + nome;

            bool flag = true;

            try
            {
                if (OpenConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                //MessageBox.Show(ex.Message);
                flag = false;
            }
            finally
            {
                CloseConnection();
            }

            return flag;

        }


    }
}