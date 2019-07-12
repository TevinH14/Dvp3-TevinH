using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TevinHamilton_CodeExercise1_EventHandlers
{
    public partial class Form1 : Form
    {
        public event EventHandler<CharArgs> LoadUserInput;
        List<UserData> completeList;
        List<UserData> requiredList;
        public Form1()
        {
            InitializeComponent();
            HandleClientWindowSize();
            completeList = new List<UserData>();
            requiredList = new List<UserData>();
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
        public void AddToCompleteListview(object sender, CharArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            // make a new user data object 
            
            //
            lvi.Text = e.ToString();
            //
            lvi.Tag = e;
            //
            lswComplete.Items.Add(lvi);
            //

        }
        public void AddToRequired(object sender, CharArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = e.ToString();
            //
            lvi.Tag = e;
            //
            lswComplete.Items.Add(lvi);
            //
            lswRequired.Items.Add(lvi);
            //
        }
        public void UpdateCompelteListView(object sender, CharArgs e)
        {
            UserData data = new UserData();
            data.Name = e.Name;
            data.Summery = e.Summery;
            data.Credits = e.Credits;
            lswComplete.SelectedItems[0].Tag = data;
        }

        public void updateRequiredListview(object sender, CharArgs e)
        {
            UserData data = new UserData();
            data.Name = e.Name;
            data.Summery = e.Summery;
            data.Credits = e.Credits;
            lswRequired.SelectedItems[0].Tag = data;
        }

        public  void btnCAdd_Click(object sender, EventArgs e)
        {
            // create a new userinput
            UserInput newUser = new UserInput();
            // subcrition to the event handleer 
            newUser.AddToComplete += AddToCompleteListview;
           
            //model form 
            newUser.Show();
        }

        
        //remove from completed list view.
        private void btnCDelete_Click(object sender, EventArgs e)
        {
            lswComplete.SelectedItems[0].Remove();
        }


       
        //remove from selecetd listview.
        private void btnRDelete_Click(object sender, EventArgs e)
        {
            lswRequired.SelectedItems[0].Remove();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a ne SaveFileDialog object.
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine("Complete List");
                //Loop threw the list based on the number of objects inside the list.
                for (int i = 0; i < completeList.Count; i++)
                {

                    writer.WriteLine(completeList[i].Name);
                    writer.WriteLine(completeList[i].Summery);
                    writer.WriteLine(completeList[i].Credits);

                }
                writer.WriteLine("Required List");
                for (int i = 0; i < requiredList.Count; i++)
                {

                    writer.WriteLine(completeList[i].Name);
                    writer.WriteLine(completeList[i].Summery);
                    writer.WriteLine(completeList[i].Credits);

                }

                //Close writer
                writer.Close();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a new instance of openfiledialog
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                //clear lists and listview in main form
                completeList.Clear();
                requiredList.Clear();
                lswComplete.Clear();
                lswRequired.Clear();

                try
                {
                    using (StreamReader sr = new StreamReader(theDialog.FileName))
                    {

                        while (sr.ReadLine() != null)
                        {
                            while (sr.ReadLine() == "Required List")
                            {
                                UserData comData = new UserData();
                                comData.Name = sr.ReadLine();
                                comData.Summery = sr.ReadLine();
                                comData.Credits = decimal.Parse(sr.ReadLine());
                                completeList.Add(comData);
                                ListViewItem lviCom = new ListViewItem();
                                lviCom.Text = comData.ToString();
                                lviCom.Tag = completeList ;
                                lswRequired.Items.Add(lviCom);
                            }
                            UserData reqData = new UserData();
                            reqData.Name = sr.ReadLine();
                            reqData.Summery = sr.ReadLine();
                            reqData.Credits = decimal.Parse(sr.ReadLine());
                            requiredList.Add(reqData);
                            ListViewItem lviReq = new ListViewItem();
                            lviReq.Text = reqData.ToString();
                            lviReq.Tag = reqData;
                            lswRequired.Items.Add(lviReq);
                            
                        }
                        //close StreamReader
                        sr.Close();
                        
                    }

                }
                catch (Exception ex)
                {
                    // send user a error message if they cant open it.
                    MessageBox.Show("selected file is not a Stock File or File is empty");
                }
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRAdd_Click(object sender, EventArgs e)
        {
            // create a new userinput
            UserInput newUser = new UserInput();
            // subcrition to the event handleer 
            newUser.AddToRequired+= AddToRequired;

            //model form 
            newUser.Show();
        }

        private void lswComplete_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // create a new userinput
            UserInput newUser = new UserInput();
            // subcrition to the event handleer 
            newUser.EditComplete += UpdateCompelteListView;
            LoadUserInput += newUser.PopulateUserData;
            //model form 
            if (LoadUserInput != null)
            {
                CharArgs args = (CharArgs)lswComplete.SelectedItems[0].Tag;

                LoadUserInput(this, args);
            }
            newUser.ShowDialog();
           
        }

        private void btnMoveToCom_Click(object sender, EventArgs e)
        {
            CharArgs args = (CharArgs)lswComplete.SelectedItems[0].Tag;
            ListViewItem list = new ListViewItem();
            list.Text = args.ToString();
            list.Tag = args;
            lswRequired.Items.Add(list);
        }
    }
}
