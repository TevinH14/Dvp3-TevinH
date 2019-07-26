using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        string player1Color = null;
        string player2Color = null;
        string player1Letter = null;
        string player2Letter = null;
        ImageList player1image = null;
        ImageList player2image = null;

        public frmTicTacToe()
        {
            InitializeComponent();

        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1Color = "Blue";
            player2Color = "Red";

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1Color = "Red";
            player2Color = "Blue";
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1Letter = "X";
            player2Letter = "O";
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1Letter = "O";
            player2Letter = "X";
        }
       
        //private void WinnerCheck()
        ////{
        ////    bool winner = false
        ////    If
        //}

        private void r1c1button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (playerTurn==true)
            {
                if (player1Color == "Red" && player1Letter == "X")
                {
                    b.ImageList = redImages;
                    b.ImageIndex = 1;

                }
                else if (player1Color == "Red" && player1Letter == "O")
                {

                    b.ImageList = redImages;
                    b.ImageIndex = 0;
                }
                else if (player1Color == "Blue" && player1Letter == "O")
                {

                    b.ImageList = blueImages;
                    b.ImageIndex = 0;
                }
                else if (player1Color == "Blue" && player1Letter == "X")
                {
                    b.ImageList = blueImages;
                    b.ImageIndex = 1;
                }
                playerTurn = false;
            }

            else
            {

                if (player2Color == "Red" && player2Letter == "X")
                {
                    b.ImageList = redImages;
                    b.ImageIndex = 1;

                }
                else if (player2Color == "Red" && player2Letter == "O")
                {

                    b.ImageList = redImages;
                    b.ImageIndex = 0;
                }
                else if (player2Color == "Blue" && player2Letter == "O")
                {

                    b.ImageList = blueImages;
                    b.ImageIndex = 0;
                }
                else if (player2Color == "Blue" && player2Letter == "X")
                {
                    b.ImageList = blueImages;
                    b.ImageIndex = 1;
                }
               
                playerTurn = true;

            }
        }
    }
}
