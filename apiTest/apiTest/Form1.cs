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
using System.IO;
using System.Web;

namespace apiTest
{
    public partial class Form1 : Form
    {
        WebClient apiConnection = new WebClient();
        string apiEndPoint = "https://swapi.co/api/starships/9/";

       
        public Form1()
        {
            InitializeComponent();
            var apiData = apiConnection.DownloadString(apiEndPoint);
            JObject o = JObject.Parse(apiData);

            string p = o["name"].ToString(); 

           // string sdf = p["name"].ToString() ;

            string specificsName = o["Results"][0]["name"].ToString();
            string name = specificsName;
            MessageBox.Show(name);
        }

        public static object Unirest { get; set; }
    }
}
