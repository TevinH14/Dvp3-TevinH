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
    /*
    * Tevin Hamilton
    * dvp3
    * code assignmet 1 
    * 1907
    */
    public partial class Form1 : Form
    {
        //create a event handlwer to send data to the userin put form
        public event EventHandler<CharArgs> LoadUserInput;
        // 2 list to hold the completed course and required course
        List<CharArgs> completeList;
        List<CharArgs> requiredList;

        public Form1()
        {
            InitializeComponent();
            HandleClientWindowSize();
            //manke a new instance of the list.
            completeList = new List<CharArgs>();
            requiredList = new List<CharArgs>();
        }
        // for the moblie background.
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
        //Add user input values to the complete alist view 
        public void AddToCompleteListview(object sender, CharArgs e)
        {
            //create a new instance of a list view item
            ListViewItem lvi = new ListViewItem();
            // add user data to the list  
            completeList.Add(e);
            //set the text on how the item will be vied in the list view 
            lvi.Text = e.ToString();
            //save the charArgs data to the list view tag properite 
            lvi.Tag = e;
            //add to list view 
            lswComplete.Items.Add(lvi);
            //
        }
        //add items to the list view 
        public void AddToRequired(object sender, CharArgs e)
        {
            // add user data to the list 
            requiredList.Add(e);
            //create a new instance of a list view item
            ListViewItem lvi = new ListViewItem();
            //set the text on how the item will be vied in the list view 
            lvi.Text = e.ToString();
          //save the charArgs data to the list view tag properite 
            lvi.Tag = e;
            //add to list view 
            lswRequired.Items.Add(lvi);
        }
        public void UpdateCompelteListView(object sender, CharArgs e)
        {
            //get the selected item in the list view 
           int index = lswComplete.SelectedIndices[0];
            //remove the old object in the list and update with the new data.
            completeList.RemoveAt(index);
            lswComplete.SelectedItems[0].Tag = e;
            completeList.Insert(index,e);
        }
        //update the required data
        public void updateRequiredListview(object sender, CharArgs e)
        {
            //get the selected item in the list view 
            int index = lswComplete.SelectedIndices[0];
            //remove the old object in the list and update with the new data.
            requiredList.RemoveAt(index);
            requiredList.Insert(index, e);
            lswRequired.SelectedItems[0].Tag = e;
        }
        //open a new userinput form.
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
            //make sure the program don't crash
            try
            {
                int index = lswComplete.SelectedIndices[0];
                completeList.RemoveAt(index);
                lswComplete.SelectedItems[0].Remove();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        //remove from selecetd listview.
        private void btnRDelete_Click(object sender, EventArgs e)
        {
            try
            {
                lswRequired.SelectedItems[0].Remove();
                int index = lswComplete.SelectedIndices[0];
                requiredList.RemoveAt(index);
            }
            catch (Exception)
            {

                throw;
            } 
        }
        //save user data
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create a ne SaveFileDialog object.
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                writer.WriteLine("Mobile development List");
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

                    writer.WriteLine(requiredList[i].Name);
                    writer.WriteLine(requiredList[i].Summery);
                    writer.WriteLine(requiredList[i].Credits);

                }

                //Close writer
                writer.Close();
            }
        }
        //Load user data
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
                            while (sr.ReadLine() != "Required List")
                            {
                                CharArgs comData = new CharArgs();
                                comData.Name = sr.ReadLine();
                                comData.Summery = sr.ReadLine();
                                comData.Credits = decimal.Parse(sr.ReadLine());
                                completeList.Add(comData);
                                ListViewItem lviCom = new ListViewItem();
                                lviCom.Text = comData.ToString();
                                lviCom.Tag = completeList ;
                                lswComplete.Items.Add(lviCom);
                            }
                            //create a new instance and save the data to right list 
                            CharArgs reqData = new CharArgs();
                            reqData.Name = sr.ReadLine();
                            reqData.Summery = sr.ReadLine();
                            reqData.Credits = decimal.Parse(sr.ReadLine());
                            requiredList.Add(reqData);
                            //save items to the list view
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
        // allow the user to add items to the required listview 
        private void btnRAdd_Click(object sender, EventArgs e)
        {
            // create a new userinput
            UserInput newUser = new UserInput();
            // subcrition to the event handleer 
            newUser.AddToRequired+= AddToRequired;

            //model form 
            newUser.Show();
        }
        //allow user to select and open new userinput form
        private void lswComplete_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // create a new userinput
            UserInput newUser = new UserInput();
            // subcrition to the event handleer 
            newUser.EditComplete += UpdateCompelteListView;
            LoadUserInput += newUser.PopulateUserData;
            newUser.EditRequired += updateRequiredListview;
            //model form 
            if (LoadUserInput != null)
            {
                CharArgs args = (CharArgs)lswComplete.SelectedItems[0].Tag;

                LoadUserInput(this, args);
            }
            newUser.ShowDialog();
           
        }
        //move data to the complete list view
        private void btnMoveToCom_Click(object sender, EventArgs e)
        {
            try
            {
                //move and data to required list view and remove from old list view.
                CharArgs args = (CharArgs)lswRequired.SelectedItems[0].Tag;
                ListViewItem list = new ListViewItem();
                list.Text = args.ToString();
                list.Tag = args;
                lswComplete.Items.Add(list);
                lswRequired.SelectedItems[0].Remove();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        //move data to the required list view 
        private void btnMoveToReq_Click(object sender, EventArgs e)
        {
            try
            {
                CharArgs args = (CharArgs)lswComplete.SelectedItems[0].Tag;
                ListViewItem list = new ListViewItem();
                list.Text = args.ToString();
                list.Tag = args;
                lswRequired.Items.Add(list);
                lswComplete.SelectedItems[0].Remove();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
