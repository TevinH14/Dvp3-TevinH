using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace HamiltonTevin_FinalProject
{
    /* 
    * Tevin Hamilton
    * term 1907
    * assignment 2 
    */
    public static class DBUtilities
    {
        public static string ConnectionString()
        {
            string serverIP = "";
            string port = "";
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\VFW\connect.txt"))
                {
                    //varibles to read the.txt file 
                    serverIP = sr.ReadLine();
                    port = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString()); 
            }
            return $"server={serverIP};uid=dbsAdmin;pwd=password;database=HamiltonTevin_FinalProject;SslMode=none;port={port};";
        }

        public static MySqlConnection connect(string myConnString) 
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = myConnString;
                conn.Open();
                MessageBox.Show("connect");
            }
            catch (MySqlException e)
            {

                switch (e.Number)
                {
                    case 1042:
                        MessageBox.Show("Can't resolve host address. \n\n" +myConnString);
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username or password. \n\n" + myConnString);
                        break;
                    default:
                        MessageBox.Show(e.ToString()+"\n\n"+ myConnString);
                        break;
                }
            }
            return conn;
        }
    }
}
