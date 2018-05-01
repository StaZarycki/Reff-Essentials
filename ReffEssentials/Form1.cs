using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReffEssentials
{
    public partial class Form1 : Form
    {
        string player1, player2;
        int player1Score = 0, player2Score = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btLoad_Click(object sender, EventArgs e)
        {
            player1 = tbPlayer1.Text;
            player2 = tbPlayer2.Text;

            setScore();
        }


        //Scoring

        private void btPlayer1Add_Click(object sender, EventArgs e)
        {
            if (player1Score >= 0)
            {
                player1Score++;
                setScore();
            }
        }

        private void btPlayer1Remove_Click(object sender, EventArgs e)
        {
            if (player1Score > 0)
            {
                player1Score--;
                setScore();
            }
        }

        private void btPlayer2Add_Click(object sender, EventArgs e)
        {
            if (player2Score >= 0)
            {
                player2Score++;
                setScore();
            }
        }


        private void btPlayer2Remove_Click(object sender, EventArgs e)
        {
            if (player2Score > 0)
            {
                player2Score--;
                setScore();
            }
        }


        //Setting Score

        public void setScore()
        {
            lbPlayer1V.Text = player1 + " - " + player1Score;
            lbPlayer2V.Text = player2 + " - " + player2Score;

            lbResult.Text = player1 + " |" + player1Score + " : " + player2Score + "| " + player2;
            lbCopied.Visible = false;
        }


        //Copying

        private void btCopy_Click(object sender, EventArgs e)
        {
            lbCopied.Visible = true;
            System.Windows.Forms.Clipboard.SetText(lbResult.Text);
        }
    }
}
