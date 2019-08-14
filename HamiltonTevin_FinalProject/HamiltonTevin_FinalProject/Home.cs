using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamiltonTevin_FinalProject
{
    public partial class Home : Form
    {
        string userChoice;
        public Home()
        {
            InitializeComponent();
            HandleClientWindowSize();
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

        private void pbC_Click(object sender, EventArgs e)
        {
            userChoice ="people";
            ListDisplay display = new ListDisplay(userChoice);
            display.Show();
            
        }

        private void pbF_Click(object sender, EventArgs e)
        {
            userChoice = "Films";
        }

        private void pbV_Click(object sender, EventArgs e)
        {

        }

        private void pbSS_Click(object sender, EventArgs e)
        {

        }

        private void pbP_Click(object sender, EventArgs e)
        {

        }

        private void pbS_Click(object sender, EventArgs e)
        {

        }
    }
}
