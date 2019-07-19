using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamiltonTevin_Assignment2
{
    public partial class UserInputForm : Form
    {
        public event EventHandler<MovieArgs> UpdateMovie;
        public event EventHandler<MovieArgs> AddMovie;
        public UserInputForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MovieArgs args = new MovieArgs(txtTitle.Text,txtYear.Text,
                txtPub.Text, txtDir.Text, txtGenre.Text);
            UpdateMovie?.Invoke(this, args);
            AddMovie?.Invoke(this, args);
            this.Close();
            this.Close();
        }
        //populate text boxes
        public void PopulateData(object sender, MovieArgs e)
        {
            txtTitle.Text = e._title;
            txtYear.Text = e._YearReleased;
            txtPub.Text = e._publisher;
            txtDir.Text = e._director;
            txtGenre.Text = e._genre;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
