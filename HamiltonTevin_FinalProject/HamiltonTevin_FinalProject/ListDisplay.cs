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
    public partial class ListDisplay : Form
    {
        WebClient apiConnection = new WebClient();
        string apiEndPoint = "https://swapi.co/api/people/1/";
        List<string> selecteditems = new List<string>();
        string userChoice;
        public ListDisplay(string uc)
        {
            InitializeComponent();
            HandleClientWindowSize();
            userChoice = uc;
            LoadData();
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
        private void LoadData()
        {
            //save api data to buttons
            var apiData = apiConnection.DownloadString("https://swapi.co/api/people/1/");
            JObject one = JObject.Parse(apiData);
            button1.Text = one["name"].ToString();
            selecteditems.Add(one["url"].ToString());

            var apiData2 = apiConnection.DownloadString("https://swapi.co/api/people/2/");
            JObject two = JObject.Parse(apiData2);
            button2.Text = two["name"].ToString();
            selecteditems.Add(two["url"].ToString());


            var apiData3 = apiConnection.DownloadString("https://swapi.co/api/people/3/");
            JObject three = JObject.Parse(apiData3);
            button3.Text = three["name"].ToString();
            selecteditems.Add(three["url"].ToString());


            var apiData4 = apiConnection.DownloadString("https://swapi.co/api/people/4/");
            JObject four = JObject.Parse(apiData4);
            button4.Text = four["name"].ToString();
            selecteditems.Add(four["url"].ToString());


            var apiData5 = apiConnection.DownloadString("https://swapi.co/api/people/5/");
            JObject five = JObject.Parse(apiData5);
            button5.Text = five["name"].ToString();
            selecteditems.Add(five["url"].ToString());

            var apiData6 = apiConnection.DownloadString("https://swapi.co/api/people/6/");
            JObject six = JObject.Parse(apiData6);
            button6.Text = six["name"].ToString();
            selecteditems.Add(six["url"].ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoDisplay info = new InfoDisplay(selecteditems[0]);
            info.Show();
        }
    }
}
