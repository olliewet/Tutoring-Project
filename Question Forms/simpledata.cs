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

namespace Tutoring_Project.Question_Forms
{
    public partial class simpledata : Form
    {
        public simpledata()
        {
            InitializeComponent();
        }

        int counter;
       
             

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

        private void Con_btn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Back_btn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void SimpleQ1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                tabControl1.SelectTab(3);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(4, 5);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(4, 5);
                    User.Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(4, 5);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(4, 5);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void SimpleQ2_btn(object sender, EventArgs e)
        {
            counter = 0;
            counter++;
            if (counter >= 3)
            {
                MessageBox.Show("OO Programming allows for better organisation since code can be put into smaller size chunks"); //Add Hit 
            }
                    
            if (radioButton7.Checked)
            {
                tabControl1.SelectTab(4);
                if ((string)this.pictureBox1.Tag == "user1")
                {                  
                    User.User1(5, 6);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(5, 6);
                    User.Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(5, 6);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(5, 6);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
            
        }
        

        private void SimpleQ3_btn(object sender, EventArgs e)
        {
            
            counter = 0; 
            counter++;
            if (counter >= 3 )
            {
                MessageBox.Show("Remember What we previously Covered, these three keywords are required otherwise the program will not compile and erros will be thrown, go back to the previous page if help is needed."); //Add Hit 
            } 

                        
            if (textBox1.Text.Equals("static") | (textBox1.Text.Equals("Static") && textBox2.Text.Equals("void") | textBox2.Text.Equals("Void") && textBox3.Text.Equals("Main()") | textBox3.Text.Equals("main()"))) //Statement Might be Incorrect  
            {
                tabControl1.SelectTab(6);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(6,7);
                    User.Exp();
                    MessageBox.Show("Well Done Section Completed, Achievement Unlocked!");
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(6, 7);
                    User.Exp2();
                    MessageBox.Show("Well Done Section Completed, Achievement Unlocked!");
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(6, 7);
                    User.Exp3();
                    MessageBox.Show("Well Done Section Completed, Achievement Unlocked!");
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(6, 7);
                    User.Exp4();
                    MessageBox.Show("Well Done Section Completed, Achievement Unlocked!");
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

       

        private void Prevobj_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void TabPage4_Click(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prevquestion2_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void SimpleQ4_btn(object sender, EventArgs e)
        {
            counter = 0;
            counter++;
            if (counter >= 3)
            {
                MessageBox.Show("OO Programming allows for better organisation since code can be put into smaller size chunks"); //Add Hit 
            }

            if (rb_2.Checked)
            {
                tabControl1.SelectTab(4);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(7,8);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(7,8);
                    User.Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(7,8);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(7,8);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }
    }
}
