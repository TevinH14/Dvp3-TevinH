namespace TevinHamilton_CodeExercise1_EventHandlers
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMoveToReq = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.lswComplete = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMoveToCom = new System.Windows.Forms.Button();
            this.btnRDelete = new System.Windows.Forms.Button();
            this.btnRAdd = new System.Windows.Forms.Button();
            this.lswRequired = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(57, 190);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(588, 980);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMoveToReq);
            this.tabPage1.Controls.Add(this.btnCDelete);
            this.tabPage1.Controls.Add(this.btnCAdd);
            this.tabPage1.Controls.Add(this.lswComplete);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 933);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Complete";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnMoveToReq
            // 
            this.btnMoveToReq.Location = new System.Drawing.Point(24, 640);
            this.btnMoveToReq.Name = "btnMoveToReq";
            this.btnMoveToReq.Size = new System.Drawing.Size(513, 79);
            this.btnMoveToReq.TabIndex = 5;
            this.btnMoveToReq.Text = "Move";
            this.btnMoveToReq.UseVisualStyleBackColor = true;
            this.btnMoveToReq.Click += new System.EventHandler(this.btnMoveToReq_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.Location = new System.Drawing.Point(24, 833);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(513, 79);
            this.btnCDelete.TabIndex = 3;
            this.btnCDelete.Text = "Delete";
            this.btnCDelete.UseVisualStyleBackColor = true;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(24, 511);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(513, 79);
            this.btnCAdd.TabIndex = 1;
            this.btnCAdd.Text = "Add";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // lswComplete
            // 
            this.lswComplete.Location = new System.Drawing.Point(6, 6);
            this.lswComplete.Name = "lswComplete";
            this.lswComplete.Size = new System.Drawing.Size(560, 461);
            this.lswComplete.TabIndex = 0;
            this.lswComplete.UseCompatibleStateImageBehavior = false;
            this.lswComplete.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lswComplete_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMoveToCom);
            this.tabPage2.Controls.Add(this.btnRDelete);
            this.tabPage2.Controls.Add(this.btnRAdd);
            this.tabPage2.Controls.Add(this.lswRequired);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 933);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Required";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMoveToCom
            // 
            this.btnMoveToCom.Location = new System.Drawing.Point(30, 662);
            this.btnMoveToCom.Name = "btnMoveToCom";
            this.btnMoveToCom.Size = new System.Drawing.Size(513, 79);
            this.btnMoveToCom.TabIndex = 5;
            this.btnMoveToCom.Text = "Move";
            this.btnMoveToCom.UseVisualStyleBackColor = true;
            this.btnMoveToCom.Click += new System.EventHandler(this.btnMoveToCom_Click);
            // 
            // btnRDelete
            // 
            this.btnRDelete.Location = new System.Drawing.Point(30, 827);
            this.btnRDelete.Name = "btnRDelete";
            this.btnRDelete.Size = new System.Drawing.Size(513, 79);
            this.btnRDelete.TabIndex = 4;
            this.btnRDelete.Text = "Delete";
            this.btnRDelete.UseVisualStyleBackColor = true;
            this.btnRDelete.Click += new System.EventHandler(this.btnRDelete_Click);
            // 
            // btnRAdd
            // 
            this.btnRAdd.Location = new System.Drawing.Point(30, 517);
            this.btnRAdd.Name = "btnRAdd";
            this.btnRAdd.Size = new System.Drawing.Size(513, 79);
            this.btnRAdd.TabIndex = 2;
            this.btnRAdd.Text = "Add";
            this.btnRAdd.UseVisualStyleBackColor = true;
            this.btnRAdd.Click += new System.EventHandler(this.btnRAdd_Click);
            // 
            // lswRequired
            // 
            this.lswRequired.Location = new System.Drawing.Point(6, 6);
            this.lswRequired.Name = "lswRequired";
            this.lswRequired.Size = new System.Drawing.Size(544, 471);
            this.lswRequired.TabIndex = 0;
            this.lswRequired.UseCompatibleStateImageBehavior = false;
            this.lswRequired.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lswComplete_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 1354);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCDelete;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.ListView lswComplete;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRDelete;
        private System.Windows.Forms.ListView lswRequired;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnMoveToReq;
        private System.Windows.Forms.Button btnMoveToCom;
        private System.Windows.Forms.Button btnRAdd;
    }
}

