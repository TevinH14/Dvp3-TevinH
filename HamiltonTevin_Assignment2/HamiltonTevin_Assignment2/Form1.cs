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
using System.IO;

namespace HamiltonTevin_Assignment2
{
    public partial class Form1 : Form
    {
        public event EventHandler<MovieArgs> LoadData;
        //used to hold the data from database 
        DataTable movieCollection = new DataTable();
        //will hold the conncetion to the database 
        MySqlConnection conn = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
            //call to make changes to the form
            HandleClientWindowSize();
            //call the connection string 
            string connString = DBUtilities.ConnectionString();
            //connect to database
            conn = DBUtilities.connect(connString);
            //populate list view
            RetrieveData();
       
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
        private bool RetrieveData()
        {
            //create a sql statement
            string sql = "SELECT Title,YearReleased,Publisher,Director,Genre " +
                "From SeriesTitles;";
            //create data abpater
            MySqlDataAdapter adr = new MySqlDataAdapter(sql,conn);
            //set the type for the select command
            adr.SelectCommand.CommandType = CommandType.Text;
            //the fill method add rows 
            adr.Fill(movieCollection);
            //create vairbles to hold data
            string title;
            string yearString;
            string publisher;
            string Director;
            string genre;
            for (int i = 0; i < movieCollection.Rows.Count; i++)
            {
                //save data to varibile
                title = movieCollection.Rows[i]["Title"].ToString();
                yearString = movieCollection.Rows[i]["YearReleased"].ToString();
                publisher = movieCollection.Rows[i]["Publisher"].ToString();
                Director = movieCollection.Rows[i]["Director"].ToString();
                genre = movieCollection.Rows[i]["genre"].ToString();
                // create a new instance of a object.
                MovieArgs args = new MovieArgs(title,yearString,publisher,Director,genre);
                //create a new list view item
                ListViewItem lvi = new ListViewItem();
                //assign the display text 
                //if (true)
                //{

                //}
                //else if(true)
                //{

                //}
                //else if (true)
                //{

                //}
                //else if (true)
                //{

                //}
                //else if (true)
                //{

                //}
                //display  name
                lvi.Text = args.ToString();
                // tag propertie
                lvi.Tag = args;
                //add to list view 
                lvwMovie.Items.Add(lvi);

            }
            conn.Close();
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
