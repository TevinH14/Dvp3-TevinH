namespace HamiltonTevin_FinalProject
{
    partial class InfoDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBBY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSkinColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddToFavorites = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(209, 366);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(320, 31);
            this.txtName.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HamiltonTevin_FinalProject.Properties.Resources.guille_pozzi_sbcIAn4Mn14_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(57, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 948);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxtGender
            // 
            this.TxtGender.Location = new System.Drawing.Point(209, 437);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.ReadOnly = true;
            this.TxtGender.Size = new System.Drawing.Size(320, 31);
            this.TxtGender.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(209, 511);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(320, 31);
            this.txtHeight.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height";
            // 
            // txtBBY
            // 
            this.txtBBY.Location = new System.Drawing.Point(209, 579);
            this.txtBBY.Name = "txtBBY";
            this.txtBBY.ReadOnly = true;
            this.txtBBY.Size = new System.Drawing.Size(320, 31);
            this.txtBBY.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 579);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bitrth year";
            // 
            // txtSkinColor
            // 
            this.txtSkinColor.Location = new System.Drawing.Point(209, 661);
            this.txtSkinColor.Name = "txtSkinColor";
            this.txtSkinColor.ReadOnly = true;
            this.txtSkinColor.Size = new System.Drawing.Size(320, 31);
            this.txtSkinColor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 661);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Skin color";
            // 
            // btnAddToFavorites
            // 
            this.btnAddToFavorites.Location = new System.Drawing.Point(110, 880);
            this.btnAddToFavorites.Name = "btnAddToFavorites";
            this.btnAddToFavorites.Size = new System.Drawing.Size(419, 105);
            this.btnAddToFavorites.TabIndex = 13;
            this.btnAddToFavorites.Text = "Add To Favorites";
            this.btnAddToFavorites.UseVisualStyleBackColor = true;
            this.btnAddToFavorites.Click += new System.EventHandler(this.btnAddToFavorites_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::HamiltonTevin_FinalProject.Properties.Resources.keyboard_right_arrow_button;
            this.btnBack.Location = new System.Drawing.Point(84, 228);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 105);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::HamiltonTevin_FinalProject.Properties.Resources.iPhone7Image_copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 1280);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddToFavorites);
            this.Controls.Add(this.txtSkinColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBBY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InfoDisplay";
            this.Text = "InfoDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBBY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSkinColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddToFavorites;
        private System.Windows.Forms.Button btnBack;
    }
}