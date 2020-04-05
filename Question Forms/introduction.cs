using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring_Project
{
    public partial class introduction : Form
    {
        public introduction()
        {
            InitializeComponent();
        }

        int counter1;
        int counter2;
        int counter3;


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

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Question1_btn(object sender, EventArgs e)
        {
            counter1++;
            if (counter1 == 3)
            {
                MessageBox.Show("This course covers the language C# and the underlying principles of the programming");
            }
            if (btn_3.Checked)
            {
                tabControl1.SelectTab(2);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(0, 1);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(0, 1);
                    User.Exp2();                   
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(0, 1);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(0, 1);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Question2_btn(object sender, EventArgs e)
        {
            counter2++;
            if (counter2 == 3)
            {
                MessageBox.Show("The purpose of OO programming is to be able to break code down into sizeable chunks, which allow for easier and more orangissed coding");
            }
           
            if (radioButton7.Checked)
            {
                tabControl1.SelectTab(4);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(1, 2);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(1, 2);
                    User.Exp2();
                } else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(1, 2);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(1, 2);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
            
        }

        #region Tab Buttons
        private void Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void Back_btn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void Question3_btn(object sender, EventArgs e)
        {
            counter3++;
            if (counter3 == 3)
            {
                MessageBox.Show("Compilers are used with converting code into low level instructions");
            }
            if (radioButton1.Checked)
            {
                tabControl1.SelectTab(6);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(2, 3);
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(2, 3);
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    User.Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(2, 3);
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(2, 3);
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void FinishSection_btn(object sender, EventArgs e)
        {
            this.Hide();
            Topics T = new Topics();
            if ((string)this.pictureBox1.Tag == "user1")
            {
                User.User1(3, 4);
                MessageBox.Show("Well Done Section Completed, Badge and achievement Unlocked!");
                User.Exp();
                T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                T.pictureBox1.Tag = "user1";             
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                User.User2(3, 4);
                MessageBox.Show("Well Done Section Completed, Badge Unlocked!");
                User.Exp2();
                T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                T.pictureBox1.Tag = "user2";
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                User.User3(3, 4);
                MessageBox.Show("Well Done Section Completed, Badge Unlocked!");
                User.Exp3();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                T.pictureBox1.Tag = "user3";               
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                User.User4(3, 4);
                MessageBox.Show("Well Done Section Completed, Badge Unlocked!");
                User.Exp4();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                T.pictureBox1.Tag = "user4";
            }
            this.Close();
            T.ShowDialog();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
