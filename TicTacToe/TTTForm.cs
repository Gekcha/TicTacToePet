using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TTTForm : Form
    {
        bool turn = true;
        int turn_count = 0;

        public TTTForm()
        {
            InitializeComponent();
        }

        private void TTTForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (turn_count == 9) return;

            Button b = (Button)sender;

            if (b.Text != "") return;

            if (turn)
            {
                b.ForeColor = Color.OrangeRed;
                b.Text = "X";
            }
            else
            {
                b.ForeColor = Color.LightSkyBlue;
                b.Text = "O";
            }

            turn = !turn;
            turn_count++;

            checkForWin();
        }

        private void checkForWin ()
        {
            bool there_is_a_winner = false;

            if (A1.Text == A2.Text && A2.Text == A3.Text && A1.Text != "")
                there_is_a_winner = true;
            else if (B1.Text == B2.Text && B2.Text == B3.Text && B1.Text != "")
                there_is_a_winner = true;
            else if (C1.Text == C2.Text && C2.Text == C3.Text && C1.Text != "")
                there_is_a_winner = true;

            else if (A1.Text == B1.Text && B1.Text == C1.Text && A1.Text != "")
                there_is_a_winner = true;
            else if (A2.Text == B2.Text && B2.Text == C2.Text && A2.Text != "")
                there_is_a_winner = true;
            else if (A3.Text == B3.Text && B3.Text == C3.Text && A3.Text != "")
                there_is_a_winner = true;

            else if (A1.Text == B2.Text && B2.Text == C3.Text && A1.Text != "")
                there_is_a_winner = true;
            else if (A3.Text == B2.Text && B2.Text == C1.Text && A3.Text != "")
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                turn_count = 9;
                String winner = "";
                if (!turn)
                    winner = "X";
                else
                    winner = "O";

                MessageBox.Show(winner + " Wins!", "Grats!!!");
            }
            else
                if (turn_count == 9)
            {
                MessageBox.Show("Draw!", "Good Game!!!");

            }


        }
    }
}
