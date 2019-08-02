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
    public partial class SignUp : Form
    {
        MySqlConnection conn = new MySqlConnection();
        string connString;

        public SignUp()
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
        //add user data to dataBase
        private void btnDone_Click(object sender, EventArgs e)
        {
            //prompt the user and valdidation using Utility class and duble check the user know the password they entered 
            string userUN = txtFName.Text;
            string userLN = txtLName.Text;
            string userFN = txtFName.Text;
            string userEA = txtEmail.Text;
            string userPassword = txtPassword.Text;
            // Open a connection to MySQL
            
            conn.Open();

            // Form SQL Statement
            string stm = $"insert into Users(UserName,FirstName,LastName,EmailAddress,Password)" +
                $" Values (@userUN,@userFN,@userLN,@userEA,@userPassword); ";

            // @userFN, @userLN, @userEA, @userPassword
            MySqlDataReader rdr = null;
            // Prepare SQL Statement
            MySqlCommand cmd = new MySqlCommand(stm, conn);
            cmd.Parameters.AddWithValue("@userUN", userUN);
            cmd.Parameters.AddWithValue("@userFN", userFN);
            cmd.Parameters.AddWithValue("@userLN", userLN);
            cmd.Parameters.AddWithValue("@userEA", userEA);
            cmd.Parameters.AddWithValue("@userPassword", userPassword);
            // Execute SQL Statement and Convert Results to a String
            rdr = cmd.ExecuteReader();
            conn.Close();
        }
        // return to the start screen
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
