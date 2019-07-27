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
using System.Xml;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        // NAME: Tevin Hamilton
        // CLASS AND TERM: DVP3/1907
        // PROJECT: Tic Tac Toe

        /* THINGS TO CONSIDER:
            - You must change the project name to conform to the required
              naming convention.
            - You must comment the code throughout.  Failure to do so could result
              in a lower grade.
            - All button names and other provided variables and controls must
              remain the same.  Changing these could result in a 0 on the project.
            - Selecting Blue or Red on the View menu should change the imageList
              attached to all buttons so that any current play will change the color
              of all button images.
            - Saved games should save to XML.  A game should load only from XML and
              should not crash the application if a user tries to load an incorrect 
              file.
        */

        bool playerTurn = true;
        string btnName = null;
        string player1Color = null;
        string player2Color = null;
        string player1Letter = null;
        string player2Letter = null;
        List<string> playerOneList;
        List<string> playerTwoList;

        public frmTicTacToe()
        {
            InitializeComponent();
            HandleClientWindowSize();
            //disable buttons 
            r1c1button.Enabled = false;
            r1c2button.Enabled = false;
            r1c3button.Enabled = false;
            r2c1button.Enabled = false;
            r2c2button.Enabled = false;
            r2c3button.Enabled = false;
            r3c1button.Enabled = false;
            r3c2button.Enabled = false;
            r3c3button.Enabled = false;
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
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instantiate the SaveFileDailog
            SaveFileDialog dlg = new SaveFileDialog();

            // we'll also set a default extension
            dlg.DefaultExt = "xml";

            // check to see if the user clicked OK
            if (DialogResult.OK == dlg.ShowDialog())
            {
                // the first we'll do is create XmlWriterSettings
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.ConformanceLevel = ConformanceLevel.Document;

                // we'll also set the indent to true
                settings.Indent = true;

                // now it's time to create the XmlWriter
                using (XmlWriter writer = XmlWriter.Create(dlg.FileName, settings))
                {
                    // the first element will define the data
                    writer.WriteStartElement("SaveGamedataData");
                    //loop the data in to xml file 
                    writer.WriteElementString("PlayerOne","player One");
                    //write the rest of the stock data to the file.
                    for (int i = 0; i < playerOneList.Count; i++)
                    {
                        writer.WriteElementString("PlayerChoice", playerOneList[i]);
                        i++;
                        writer.WriteElementString("PlayerColor", playerOneList[i]);
                        i++;
                        writer.WriteElementString("PlayerLetter", playerOneList[i]);
                    }
                    writer.WriteElementString("PlayerTwo", "player two");

                    for (int i = 0; i < playerTwoList.Count; i++)
                    {
                        writer.WriteElementString("PlayerChoice", playerTwoList[i]);
                        i++;
                        writer.WriteElementString("PlayerColor", playerTwoList[i]);
                        i++;
                        writer.WriteElementString("PlayerLetter", playerTwoList[i]);
                    }

                    // write the end element for the data
                    writer.WriteEndElement();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1Color = "Blue";
            player2Color = "Red";
            blueToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Checked = false;

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1Color = "Red";
            player2Color = "Blue";
            redToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1Letter = "X";
            player2Letter = "O";
            xToolStripMenuItem.Checked = true;
            oToolStripMenuItem.Checked = false;



        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1Letter = "O";
            player2Letter = "X";
            oToolStripMenuItem.Checked = true;
            xToolStripMenuItem.Checked = false;

        }

        private void WinnerCheck(Button b)
        {
            //wins in a row
            //row 1
            if ((r1c1button.ImageIndex == b.ImageIndex) && (r1c2button.ImageIndex == b.ImageIndex )&&(r1c3button.ImageIndex==b.ImageIndex))
            {
                if (playerTurn == true)
                {
                    MessageBox.Show($"Player 2 is the winner");
                }
                else if(playerTurn==false)
                {
                    MessageBox.Show($"Player 1 is the winner");
                }
            }
            else if ((r2c1button.ImageIndex == b.ImageIndex) && (r2c2button.ImageIndex ==b.ImageIndex)&&( r2c3button.ImageIndex==b.ImageIndex) )
            {
                if (playerTurn == true)
                {
                    MessageBox.Show($"Player 2 is the winner");
                }
                else
                {
                    MessageBox.Show($"Player 1 is the winner");
                }
            }
            else if ((r3c1button.ImageIndex == b.ImageIndex) && (r3c2button.ImageIndex == b.ImageIndex) && (r3c3button.ImageIndex == b.ImageIndex))
            {
                if (playerTurn == true)
                {
                    MessageBox.Show($"Player 2 is the winner");
                }
                else
                {
                    MessageBox.Show($"Player 1 is the winner");
                }
            }
            // vetrical wins
            else if ((r1c1button.ImageIndex == b.ImageIndex) && (r2c1button.ImageIndex == b.ImageIndex) && (r3c1button.ImageIndex == b.ImageIndex) )
            {
                if (playerTurn == true)
                {
                    MessageBox.Show($"Player 2 is the winner");
                }
                else
                {
                    MessageBox.Show($"Playerc 1 is the winner");
                }
            }
            else if ((r1c2button.ImageIndex == b.ImageIndex) && (r2c2button.ImageIndex == b.ImageIndex) && (r3c2button.ImageIndex == b.ImageIndex))
            {
                if (playerTurn == true)
                {
                    MessageBox.Show($"Player 2 is the winner");
                }
                else
                {
                    MessageBox.Show($"Playerc 1 is the winner");
                }
            }
            else if ((r1c3button.ImageIndex == b.ImageIndex) && (r2c3button.ImageIndex == b.ImageIndex) && (r3c3button.ImageIndex == b.ImageIndex))
            {
                if (playerTurn == true)
                {
                    MessageBox.Show($"Player 2 is the winner");
                }
                else
                {
                    MessageBox.Show($"Playerc 1 is the winner");
                }
            }
            else if ((r1c1button.ImageIndex == b.ImageIndex) && (r2c2button.ImageIndex == b.ImageIndex) && (r3c3button.ImageIndex == b.ImageIndex))
            {
                if (playerTurn == true)
                {
                    MessageBox.Show($"Player 2 is the winner");
                }
                else
                {
                    MessageBox.Show($"Playerc 1 is the winner");
                }
            }
            else if ((r3c1button.ImageIndex == b.ImageIndex) && (r2c2button.ImageIndex == b.ImageIndex) && (r1c3button.ImageIndex == b.ImageIndex))
            {
                if (playerTurn == true)
                {
                    MessageBox.Show($"Player 2 is the winner");
                }
                else
                {
                    MessageBox.Show($"Playerc 1 is the winner");
                }
            }


        }

        private void r1c1button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            int cont = 1;
            
            if (cont==1)
            {
                xToolStripMenuItem.Enabled = false;
                oToolStripMenuItem.Enabled = false;
                blueToolStripMenuItem.Enabled = false;
                redToolStripMenuItem.Enabled = false;
                btnStart.Enabled = false;
            }
            cont++;
            if (playerTurn==true)
            {
                if (player1Color == "Red" && player1Letter == "X")
                {
                    b.ImageList = redImages;
                    b.ImageIndex = 1;
                    string name = b.Name;
                    playerOneList.Add(name);
                    playerOneList.Add(player1Color);
                    playerOneList.Add(player1Letter);

                }
                else if (player1Color == "Red" && player1Letter == "O")
                {

                    b.ImageList = redImages;
                    b.ImageIndex = 0;
                    string name = b.Name;
                    playerOneList.Add(name);
                    playerOneList.Add(player1Color);
                    playerOneList.Add(player1Letter);
                }
                else if (player1Color == "Blue" && player1Letter == "O")
                {

                    b.ImageList = blueImages;
                    b.ImageIndex = 0;
                    string name = b.Name;
                    playerOneList.Add(name);
                    playerOneList.Add(player1Color);
                    playerOneList.Add(player1Letter);
                }
                else if (player1Color == "Blue" && player1Letter == "X")
                {
                    b.ImageList = blueImages;
                    b.ImageIndex = 1;
                    string name = b.Name;
                    playerOneList.Add(name);
                    playerOneList.Add(player1Color);
                    playerOneList.Add(player1Letter);
                }
                playerTurn = false;
            }

            else if(playerTurn==false)
            {
                //check for the color and letter
                if (player2Color == "Red" && player2Letter == "X")
                {
                    //assign but info
                    b.ImageList = redImages;
                    b.ImageIndex = 1;
                    string name = b.Name;
                   
                    playerTwoList.Add(name);
                    playerTwoList.Add(player2Color);
                    playerTwoList.Add(player2Letter);

                }
                else if (player2Color == "Red" && player2Letter == "O")
                {

                    b.ImageList = redImages;
                    b.ImageIndex = 0;
                    string name = b.Name;
                    
                    playerTwoList.Add(name);
                    playerTwoList.Add(player2Color);
                    playerTwoList.Add(player2Letter);
                }
                else if (player2Color == "Blue" && player2Letter == "O")
                {

                    b.ImageList = blueImages;
                    b.ImageIndex = 0;
                    string name = b.Name;
                    
                    playerTwoList.Add(name);
                    playerTwoList.Add(player2Color);
                    playerTwoList.Add(player2Letter);

                }
                else if ((player2Color == "Blue") && (player2Letter == "X"))
                {
                    b.ImageList = blueImages;
                    b.ImageIndex = 1;
                    string name = b.Name;
                    
                    playerTwoList.Add(name);
                    playerTwoList.Add(player2Color);
                    playerTwoList.Add(player2Letter);
                }
               
                playerTurn = true;

            }
            //pass the button info into the ninnercheck method
            WinnerCheck(b);
        }
        //newgame
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //clear all checked buttons
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            xToolStripMenuItem.Checked = false;
            oToolStripMenuItem.Checked = false;

            //remove button image.
            r1c1button.ImageIndex = -1;
            r1c2button.ImageIndex = -1;
            r1c3button.ImageIndex = -1;
            r2c1button.ImageIndex = -1;
            r2c2button.ImageIndex = -1;
            r2c3button.ImageIndex = -1;
            r3c1button.ImageIndex = -1;
            r3c2button.ImageIndex = -1;
            r3c3button.ImageIndex = -1;
            //set all playe data to null 
            player1Color = null;
            player2Color = null;
            player1Letter = null;
            player2Letter = null;
             //set player values to start values
            playerTurn = true;
            playerOneList = new List<string>();
            playerTwoList = new List<string>();
            //enabled color and x or O selection
            xToolStripMenuItem.Enabled = true;
            oToolStripMenuItem.Enabled = true;
            blueToolStripMenuItem.Enabled = true;
            redToolStripMenuItem.Enabled = true;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (((blueToolStripMenuItem.Checked != false) || (redToolStripMenuItem.Checked != false))&& ((xToolStripMenuItem.Checked != false) || (oToolStripMenuItem.Checked != false)))
            {
                //enabled selections buttons
                r1c1button.Enabled = true;
                r1c2button.Enabled = true;
                r1c3button.Enabled = true;
                r2c1button.Enabled = true;
                r2c2button.Enabled = true;
                r2c3button.Enabled = true;
                r3c1button.Enabled = true;
                r3c2button.Enabled = true;
                r3c3button.Enabled = true;

                
            }
           
        }
    }
}
