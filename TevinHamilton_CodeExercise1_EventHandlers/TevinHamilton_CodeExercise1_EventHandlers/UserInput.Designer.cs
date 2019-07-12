namespace TevinHamilton_CodeExercise1_EventHandlers
{
    partial class UserInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInput));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnAddCom = new System.Windows.Forms.Button();
            this.numCreditHours = new System.Windows.Forms.NumericUpDown();
            this.txtxCourseDetails = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnAddReq = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditHours)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnAddCom);
            this.gb1.Controls.Add(this.numCreditHours);
            this.gb1.Controls.Add(this.txtxCourseDetails);
            this.gb1.Controls.Add(this.txtCourseName);
            this.gb1.Controls.Add(this.btnCancel);
            this.gb1.Controls.Add(this.BtnAddReq);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(71, 215);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(520, 868);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Course User Input Screen";
            // 
            // btnAddCom
            // 
            this.btnAddCom.Location = new System.Drawing.Point(50, 434);
            this.btnAddCom.Name = "btnAddCom";
            this.btnAddCom.Size = new System.Drawing.Size(428, 76);
            this.btnAddCom.TabIndex = 8;
            this.btnAddCom.Text = "Add To Complete ";
            this.btnAddCom.UseVisualStyleBackColor = true;
            this.btnAddCom.Click += new System.EventHandler(this.btnAddCom_Click);
            // 
            // numCreditHours
            // 
            this.numCreditHours.Location = new System.Drawing.Point(50, 342);
            this.numCreditHours.Name = "numCreditHours";
            this.numCreditHours.Size = new System.Drawing.Size(356, 31);
            this.numCreditHours.TabIndex = 7;
            // 
            // txtxCourseDetails
            // 
            this.txtxCourseDetails.Location = new System.Drawing.Point(50, 224);
            this.txtxCourseDetails.Name = "txtxCourseDetails";
            this.txtxCourseDetails.Size = new System.Drawing.Size(428, 31);
            this.txtxCourseDetails.TabIndex = 6;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(46, 112);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(432, 31);
            this.txtCourseName.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(50, 734);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(428, 76);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnAddReq
            // 
            this.BtnAddReq.Location = new System.Drawing.Point(50, 554);
            this.BtnAddReq.Name = "BtnAddReq";
            this.BtnAddReq.Size = new System.Drawing.Size(428, 76);
            this.BtnAddReq.TabIndex = 3;
            this.BtnAddReq.Text = "Add to Requird";
            this.BtnAddReq.UseVisualStyleBackColor = true;
            this.BtnAddReq.Click += new System.EventHandler(this.BtnAddReq_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Credits:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name:";
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserInput";
            this.Text = "UserInput";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCreditHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.NumericUpDown numCreditHours;
        private System.Windows.Forms.TextBox txtxCourseDetails;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnAddReq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCom;
    }
}