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
        string movieName;
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
                lvi.ImageIndex = 0;
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
            UserInputForm inputForm = new UserInputForm();
            inputForm.AddMovie += AddToDataBase;
            inputForm.ShowDialog();
        }
        public void AddToDataBase(object sender, MovieArgs e)
        {
            MovieArgs movie = new MovieArgs(e._title, e._YearReleased,
               e._publisher, e._director, e._genre);

            ListViewItem lvi = new ListViewItem();
            //display  name
            lvi.Text = movie.ToString();
            // tag propertie
            lvi.Tag = movie;
            //add to list view 
            lvwMovie.Items.Add(lvi);

            //string to hold the sql statement
            string sql = "insert into SeriesTitles(Title,YearReleased,publisher,Director,genre) " +
                $" value('{e._title}','{e._YearReleased}','{e._publisher}','{e._director}','{e._genre}' );";
            //open connection
            conn.Open();
            MySqlDataReader rdr = null;
            // Prepare SQL Statement
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            // Execute SQL Statement and Convert Results to a String
            rdr = cmd.ExecuteReader();
            //close rthe connection
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UserInputForm inputForm = new UserInputForm();
            //subcribe
            inputForm.UpdateMovie += UpdateData;
            LoadData += inputForm.PopulateData;
            movieName = lvwMovie.SelectedItems[0].Text;
            //event handler null check
            if (LoadData != null)
            {
                MovieArgs args = (MovieArgs)lvwMovie.SelectedItems[0].Tag;
                LoadData(this, args);
            }
            inputForm.ShowDialog();

        }
        public void UpdateData(object sender, MovieArgs e)
        {

            //add the user data to a new object to be save to the seleceted tag.
            MovieArgs movie = new MovieArgs(e._title, e._YearReleased,
                e._publisher, e._director,e._genre);
            //add the update values to the list view 
            lvwMovie.SelectedItems[0].Tag = movie;
            //change the name that is being seen by the user 
            lvwMovie.SelectedItems[0].Text = movie.ToString(); ;
            //update the database 
            string sql = "UPDATE SeriesTitles " +
                $"SET Title = '{e._title}', YearReleased ='{e._YearReleased}'," +
                $"publisher ='{e._publisher}', Director = '{e._director}', genre = '{e._genre}' " +
                $" WHERE Title = '{movieName}';";
            //open connection
            conn.Open();
            MySqlDataReader rdr = null;
            // Prepare SQL Statement
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            // Execute SQL Statement and Convert Results to a String
            rdr = cmd.ExecuteReader();
            //close rthe connection
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //create a new instance of the movieargs fobject.
            MovieArgs movie = (MovieArgs)lvwMovie.SelectedItems[0].Tag;
            //sql statement to delete the data
            string sql = "DELETE FROM SeriesTitles " +
               $"where title = '{movie._title}';";
            //open connection
            conn.Open();
            MySqlDataReader rdr = null;
            // Prepare SQL Statement
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            // Execute SQL Statement and Convert Results to a String
            rdr = cmd.ExecuteReader();
            //close the connection
            conn.Close();
            lvwMovie.SelectedItems[0].Remove();

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //create a ne SaveFileDialog object.
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine("MovieList");
               
                //Loop threw the list based on the number of objects inside the list.
                for (int i = 0; i < movieCollection.Rows.Count; i++)
                {
                    writer.WriteLine(movieCollection.Rows[i]["Title"].ToString());
                    writer.WriteLine(movieCollection.Rows[i]["YearReleased"].ToString());
                    writer.WriteLine(movieCollection.Rows[i]["Publisher"].ToString());
                    writer.WriteLine(movieCollection.Rows[i]["Director"].ToString());
                    writer.WriteLine(movieCollection.Rows[i]["genre"].ToString());

                }
               

                //Close writer
                writer.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
