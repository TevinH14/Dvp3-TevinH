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
    public partial class UserInput : Form
    {
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
            if (AddToComplete!=null)
            {
                AddToComplete(this, args);
            }
        }

        private void BtnAddReq_Click(object sender, EventArgs e)
        {
            CharArgs args = new CharArgs();
            args.Name = txtCourseName.Text;
            args.Summery = txtxCourseDetails.Text;
            args.Credits = numCreditHours.Value;
            if (AddToComplete != null)
            {
                AddToRequired(this, args);
            }
            this.Close();
        }

        public void PopulateUserData(object sender, CharArgs e)
        {
            txtCourseName.Text = e.Name;
            txtxCourseDetails.Text = e.Summery;
            numCreditHours.Value = e.Credits;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
