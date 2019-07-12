using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TevinHamilton_CodeExercise1_EventHandlers
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            // create a new userinput
            UserInput newUser = new UserInput(false);
            // subcrition to the event handleer 
            newUser.AddToMainForm += AddToMainForm;
            //model form 
            newUser.ShowDialog();
        }

        private void btnCEdit_Click(object sender, EventArgs e)
        {
            UserInput newUser = new UserInput(true);
            FillUserInput += newUser.FillUserInput;
            newUser.UpdateSelected += UpdateSelected;
            newUser.AddToMainForm += AddToMainForm;
            if (FillUserInput != null)
            {
                ChangeEventArgs change = (ChangeEventArgs)lvwShips.SelectedItems[0].Tag;
                // subscribe to the method in the userinput form.
                // FillUserInput += newUser.FillUserInput;
                FillUserInput(this, change);
                // show as model
                newUser.ShowDialog();
            }
        }

        private void btnCDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRAdd_Click(object sender, EventArgs e)
        {
            // create a new userinput
            UserInput newUser = new UserInput(false);
            // subcrition to the event handleer 
            newUser.AddToMainForm += AddToMainForm;
            //model form 
            newUser.ShowDialog();
        }

        private void btnREdit_Click(object sender, EventArgs e)
        {
            UserInput newUser = new UserInput(true);
            FillUserInput += newUser.FillUserInput;
            newUser.UpdateSelected += UpdateSelected;
            newUser.AddToMainForm += AddToMainForm;
            if (FillUserInput != null)
            {
                ChangeEventArgs change = (ChangeEventArgs)lvwShips.SelectedItems[0].Tag;
                // subscribe to the method in the userinput form.
                // FillUserInput += newUser.FillUserInput;
                FillUserInput(this, change);
                // show as model
                newUser.ShowDialog();
            }
        }

        private void btnRDelete_Click(object sender, EventArgs e)
        {

        }
        public void AddToMainForm(object sender, ChangeEventArgs e)
        {
            // create a new list view
            ListViewItem lvi = new ListViewItem();
            //assign values to the lvi and add it to list view
            lvi.Text = e._shipName;
            lvi.ImageIndex = e._shipIndex;
            // use the tag property 
            lvi.Tag = e;

            lvwShips.Items.Add(lvi);
            // add count objects that exist
            objCount++;
            txtCount.Text = objCount.ToString();
        }
        public void UpdateSelected(object sender, ChangeEventArgs e)
        {
            //update selected data
            lvwShips.SelectedItems[0].ImageIndex = e._shipIndex;
            lvwShips.SelectedItems[0].Text = e._shipName;
        }
    }
}
