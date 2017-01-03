using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        //bool x and o will be checked to see which turn it is
        bool x = true;
        bool o = false;
        //bool clicked will check if the buttons were pressed
        bool clicked1, clicked2, clicked3, clicked4, clicked5, clicked6, clicked7, clicked8, clicked9 = false;
        int one, two, three, four, five, six, seven, eight, nine;

        public Form1()
        {
            InitializeComponent();
            lblTurn.Text = "Player X turn";
        }

        //mouse enter shows symbol on button
        //checks which player symbol should appear and if it was previously clicked
        #region
        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked1 == false)
            {
                btn1.Text = "X";
            }
            else if (o == true && x == false && clicked1 == false)
            {
                btn1.Text = "O";
            }
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked2 == false)
            {
                btn2.Text = "X";
            }
            else if (o == true && x == false && clicked2 == false)
            {
                btn2.Text = "O";
            }
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked3 == false)
            {
                btn3.Text = "X";
            }
            else if (o == true && x == false && clicked3 == false)
            {
                btn3.Text = "O";
            }
        }

        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked4 == false)
            {
                btn4.Text = "X";
            }
            else if (o == true && x == false && clicked4 == false)
            {
                btn4.Text = "O";
            }
        }

        private void btn5_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked5 == false)
            {
                btn5.Text = "X";
            }
            else if (o == true && x == false && clicked5 == false)
            {
                btn5.Text = "O";
            }
        }

        private void btn6_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked6 == false)
            {
                btn6.Text = "X";
            }
            else if (o == true && x == false && clicked6 == false)
            {
                btn6.Text = "O";
            }
        }

        private void btn7_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked7 == false)
            {
                btn7.Text = "X";
            }
            else if (o == true && x == false && clicked7 == false)
            {
                btn7.Text = "O";
            }
        }

        private void btn8_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked8 == false)
            {
                btn8.Text = "X";
            }
            else if (o == true && x == false && clicked8 == false)
            {
                btn8.Text = "O";
            }
        }

        private void btn9_MouseEnter(object sender, EventArgs e)
        {
            if (x == true && o == false && clicked9 == false)
            {
                btn9.Text = "X";
            }
            else if (o == true && x == false && clicked9 == false)
            {
                btn9.Text = "O";
            }
        }
        #endregion

        //mouse leave causes the symbols to disappear if button was not clicked
        #region
        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            if (clicked1 == false)
            {
                btn1.Text = "";
            }
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            if (clicked2 == false)
            {
                btn2.Text = "";
            }
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            if (clicked3 == false)
            {
                btn3.Text = "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            if (clicked4 == false)
            {
                btn4.Text = "";
            }
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            if (clicked5 == false)
            {
                btn5.Text = "";
            }
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            if (clicked6 == false)
            {
                btn6.Text = "";
            }
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            if (clicked7 == false)
            {
                btn7.Text = "";
            }
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            if (clicked8 == false)
            {
                btn8.Text = "";
            }
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            if (clicked9 == false)
            {
                btn9.Text = "";
            }
        }
        #endregion

        //checks the click and shows the appropriate symbol when clicked
        //once clicked, button cannot be clicked again
        #region
        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (x == true)
            {
                btn1.Text = "X";
                clicked1 = true;
                one = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn1.Enabled = false;
                check();
            }
            else if (o == true)
            {
                btn1.Text = "O";
                clicked1 = true;
                one = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn1.Enabled = false;
                check();
            }
        }

        private void btn2_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == true)
            {
                btn2.Text = "X";
                clicked2 = true;
                two = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn2.Enabled = false;
                check();
            }
            else if (o == true)
            {
                btn2.Text = "O";
                clicked2 = true;
                two = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn2.Enabled = false;
                check();
            }
        }

        private void btn3_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == true)
            {
                btn3.Text = "X";
                clicked3 = true;
                three = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn3.Enabled = false;
                check();
            }
            else if (o == true)
            {
                btn3.Text = "O";
                clicked3 = true;
                three = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn3.Enabled = false;
                check();
            }
        }

        private void btn4_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == true)
            {
                btn4.Text = "X";
                clicked4 = true;
                four = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn4.Enabled = false;
                check();
            }
            else if (o == true)
            {
                btn4.Text = "O";
                clicked4 = true;
                four = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn4.Enabled = false;
                check();
            }
        }

        private void btn5_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == true)
            {
                btn5.Text = "X";
                clicked5 = true;
                five = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn5.Enabled = false;
                check();
            }
            else if (o == true)
            {
                btn5.Text = "O";
                clicked5 = true;
                five = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn5.Enabled = false;
                check();
            }
        }

        private void btn6_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == true)
            {
                btn6.Text = "X";
                clicked6 = true;
                six = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn6.Enabled = false;
                check();
            }
            else if (o == true)
            {
                btn6.Text = "O";
                clicked6 = true;
                six = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn6.Enabled = false;
                check();
            }
        }

        private void btn7_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == true)
            {
                btn7.Text = "X";
                clicked7 = true;
                seven = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn7.Enabled = false; 
                check();
            }
            else if (o == true)
            {
                btn7.Text = "O";
                clicked7 = true;
                seven = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn7.Enabled = false;
                check();
            }
        }

        private void btn8_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == true)
            {
                btn8.Text = "X";
                clicked8 = true;
                eight = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn8.Enabled = false;
                check();
            }
            else if (o == true)
            {
                btn8.Text = "O";
                clicked8 = true;
                eight = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn8.Enabled = false;
                check();
            }
        }

        private void btn9_MouseClick(object sender, MouseEventArgs e)
        {
            if (x == true)
            {
                btn9.Text = "X";
                clicked9 = true;
                nine = 1;
                x = false;
                o = true;
                lblTurn.Text = "Player O turn";
                btn9.Enabled = false;
                check();
            }
            else if (o == true)
            {
                btn9.Text = "O";
                clicked9 = true;
                nine = 2;
                o = false;
                x = true;
                lblTurn.Text = "Player X turn";
                btn9.Enabled = false;
                check();
            }
        }
        #endregion

        //check for winning row, or if no winning row, it declares a tie
        private void check()
        {
            if ((one==1 && two==1 && three==1)||(one==1 && four==1 && seven==1)||(two==1 && five==1 && eight==1)||(three==1 && six==1 && nine==1)||(four==1 && five==1 && six==1)||(seven==1 && eight==1 && nine==1)||(one==1 && five==1 && nine==1)||(three==1 && five==1 && seven==1))
            {
                DialogResult win = MessageBox.Show("Player X wins! Play again?", "Play again?", MessageBoxButtons.YesNo );
                if (win == DialogResult.Yes)
                {
                    
                    Application.Restart();
                }
                else if (win == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if ((one == 2 && two == 2 && three == 2) || (one == 2 && four == 2 && seven == 2) || (two == 2 && five == 2 && eight == 2) || (three == 2 && six == 2 && nine == 2) || (four == 2 && five == 2 && six == 2) || (seven == 2 && eight == 2 && nine == 2) || (one == 2 && five == 2 && nine == 2) || (three == 2 && five == 2 && seven == 2))
            {
                DialogResult win = MessageBox.Show("Player O wins! Play again? ", "Play again?", MessageBoxButtons.YesNo);
                if (win == DialogResult.Yes)
                {
                    
                    Application.Restart();
                }
                else if (win == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (btn1.Enabled == false && btn2.Enabled == false && btn3.Enabled == false && btn4.Enabled == false && btn5.Enabled == false && btn6.Enabled == false && btn7.Enabled == false && btn8.Enabled == false && btn9.Enabled ==false)
            {
                DialogResult win = MessageBox.Show("Tie! Play again? ", "Play again?", MessageBoxButtons.YesNo);
                if (win == DialogResult.Yes)
                {
                    
                    Application.Restart();
                }
                else if (win == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        
    }
}
