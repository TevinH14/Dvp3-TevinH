using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HamiltonTevin_FinalProject
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection();
         
        public Login()
        {
            InitializeComponent();
            HandleClientWindowSize();
            //call the connection string 
            string connString = DBUtilities.ConnectionString();
            //connect to database
            conn = DBUtilities.connect(connString);
            conn.Close();
        }
        void HandleClientWindowSize()
        {
            //Modify ONLY these float values
            float HeightValueToChange = 1.4f;
            float WidthValueToChange = 6.0f;

            //DO NOT MODIFY THIS CODE
            int height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Height / HeightValueToChange);
            int width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Size.Width / WidthValueToChange);
            if (height < Size.Height)
                height = Size.Height;
            if (width < Size.Width)
                width = Size.Width;
            this.Size = new Size(width, height);
            //this.Size = new Size(376, 720);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();

            // Form SQL Statement
            string stm = $"Select * from Users where UserName = @userEA and Password = @userPassword limit 1;";

            // @userFN, @userLN, @userEA, @userPassword
            MySqlDataReader rdr = null;
            // Prepare SQL Statement
            MySqlCommand cmd = new MySqlCommand(stm, conn);

            cmd.Parameters.AddWithValue("@userEA", txtUserName.Text);
            cmd.Parameters.AddWithValue("@userPassword", txtPassword.Text);

            // Execute SQL Statement and Convert Results to a String
            rdr = cmd.ExecuteReader();
            if (!rdr.HasRows)
            {
                Console.WriteLine("email or password is incorrect");
                
            }
            Home home = new Home();
            home.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
