using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;

namespace HamiltonTevin_FinalProject
{
    public partial class InfoDisplay : Form
    {
        WebClient apiConnection = new WebClient();
        string apiEndPoint;
        public InfoDisplay(string url)
        {
            InitializeComponent();
            HandleClientWindowSize();
            apiEndPoint = url;
            var apiData = apiConnection.DownloadString("https://swapi.co/api/people/1/");
            JObject o = JObject.Parse(apiData);
            txtName.Text = o["name"].ToString();
            txtHeight.Text = o["height"].ToString();
            txtSkinColor.Text = o["skin_color"].ToString();
            TxtGender.Text = o["gender"].ToString();
            txtBBY.Text = o["birth_year"].ToString();
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

        private void btnAddToFavorites_Click(object sender, EventArgs e)
        {
            //txtName.Text = o["name"].ToString();
            //txtHeight.Text = o["height"].ToString();
            //txtSkinColor.Text = o["skin_color"].ToString();
            //TxtGender.Text = o["gender"].ToString();
            //txtBBY.Text = o["birth_year"].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
