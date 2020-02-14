using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring_Project.Question_Forms
{
    public partial class SimplePart2 : Form
    {
        public SimplePart2()
        {
            InitializeComponent();
        }

        #region Variables 
        int counter;
        #endregion

        private void Topics_btn_Click(object sender, EventArgs e)
        {

            if ((string)this.pictureBox1.Tag == "user1")
            {
                this.Hide();
                Topics T = new Topics();
                T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                T.pictureBox1.Tag = "user1";
                T.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                Topics T = new Topics();
                T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                T.pictureBox1.Tag = "user2";
                T.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                Topics T = new Topics();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                T.pictureBox1.Tag = "user3";
                T.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                Topics T = new Topics();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                T.pictureBox1.Tag = "user4";
                T.ShowDialog();
                this.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to exit?";
            const string caption = "";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Simple_btn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Simple_btn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Back_btn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void Tip_btn1(object sender, EventArgs e)
        {
            MessageBox.Show("When you are writing a specification you should worry about the precision to which values are to be held. Too much accuracy may slow the machine down - too little may result in the wrong values being used.");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Note that we can go one further negative than positive. This is because the numbers are stored using 2's complement notation.");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6); 
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void Button11_Click(object sender, EventArgs e)
        {           
            string text;
            counter = 0;
            counter++;
            if (counter >= 3)
            {
                MessageBox.Show("Remember the structure of an assigenment statement, remember the difference = and ==, the single = should be used in this instance"); //Add Hit 
            }
            else if (counter >= 6)
            {
                MessageBox.Show("Example of an assigenment statement Double PreciseNumberOfDrinks = 5.1 ; ");
            }
            text = tb_4.Text;
            if (text.Contains("int") && text.Contains("numberOfDrinks") && text.Contains("=") && text.Contains("5") && text.Contains(";") | text.Contains("int") && text.Contains("numberOfDrinks") && text.Contains("=") && text.Contains("5;"))
            {
                tabControl1.SelectTab(7);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(13, 14);
                    User.Exp();

                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(13, 14);
                    User.Exp2();

                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(13, 14);
                    User.Exp3();

                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(13, 14);
                    User.Exp4();

                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finally, if you want the ultimate in precision but require a slightly smaller range you can use the decimal type. This uses twice the storage space of a double and holds values to a precision of 28-29 digits. It is used in financial calculations where the numbers are not so large but they need to be held to very high accuracy. decimal robsOverdraft;");
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            counter = 0;
            counter++;
            if (counter >= 3)
            {
                MessageBox.Show("The Question is asking about double.Parse, .Parse can be used to parse into different types depending what is infornt of the .Parse!");
            }
            if (answer_btn4.Checked)
            {
                tabControl1.SelectTab(9);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(14, 15);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(14, 15);
                    User.Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(14, 15);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(14, 15);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"this is a string\"");
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\" \\x0041BCDE\\a \""); // Needs ReCongiuring 
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ABCDE");
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void Button23_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(11);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            counter = 0;
            counter++;
            if (counter >= 3)
            {
                MessageBox.Show("HINT HINT HINT HINT");
            }
            if (Q3_btn2.Checked)
            {
                tabControl1.SelectTab(12);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(15, 16);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(15, 16);
                    User.Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(15, 16);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(15, 16);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(11);
        }
    }
}