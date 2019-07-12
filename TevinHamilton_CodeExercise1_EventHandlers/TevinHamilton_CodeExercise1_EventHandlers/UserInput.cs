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
    /*
     * Tevin Hamilton
     * dvp3
     * code assignmet 1 
     * 1907
     */
    public partial class UserInput : Form
    {
        // create event handlers to populate list view in form1 
        public event EventHandler<CharArgs> AddToComplete;
        public event EventHandler<CharArgs> AddToRequired;
        public event EventHandler<CharArgs> EditComplete;
        public event EventHandler<CharArgs> EditRequired;
        public UserInput()
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

        private void btnAddCom_Click(object sender, EventArgs e)
        {
            CharArgs args = new CharArgs();
            args.Name = txtCourseName.Text;
            args.Summery = txtxCourseDetails.Text;
            args.Credits = numCreditHours.Value;
            AddToComplete?.Invoke(this, args);
            this.Close();
        }

        private void BtnAddReq_Click(object sender, EventArgs e)
        {
            //save user input to a object to be past threw event handler
            CharArgs args = new CharArgs();
            args.Name = txtCourseName.Text;
            args.Summery = txtxCourseDetails.Text;
            args.Credits = numCreditHours.Value;
            //null check
            if (AddToRequired != null)
            {
                AddToRequired(this, args);
            }
            this.Close();
        }
        //gether the data from form one and populate the ccontrols
        public void PopulateUserData(object sender, CharArgs e)
        {
            txtCourseName.Text = e.Name;
            txtxCourseDetails.Text = e.Summery;
            numCreditHours.Value = e.Credits;
        }

        //close the current user input form 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //pass the update userinput to form 1 
        private void btnUpdateCom_Click(object sender, EventArgs e)
        {
            CharArgs args = new CharArgs();
            args.Name = txtCourseName.Text;
            args.Summery = txtxCourseDetails.Text;
            args.Credits = numCreditHours.Value;
            // null check to see if the event handler is working 
            if (EditComplete!=null)
            {
                EditComplete(this, args);
            }
            this.Close();
        }
        //pass updated userinput to form 1
        private void btnUpdateReq_Click(object sender, EventArgs e)
        {
            CharArgs args = new CharArgs();
            args.Name = txtCourseName.Text;
            args.Summery = txtxCourseDetails.Text;
            args.Credits = numCreditHours.Value;
            if (EditRequired!=null)
            {
                EditRequired(this,args);
            }
            this.Close();
        }
    }
}
