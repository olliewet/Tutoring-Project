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
                MessageBox.Show("Classes are the main part of OO Programming, Classes act like a container to hold code."); //Add Hit 
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
        #region Unused or pointless buttons
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

        #endregion

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
                tabControl1.SelectTab(8);
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

        private void Button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void Tip_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These variables are stored as doubles, as they are storing numbers however numbers can stored be stored as floats or ints depending on how precise it has to be regrading floating points. Also, dont forgot the semi-colon after declaring the variables!");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            string text;
            counter = 0;
            counter++;
            if (counter >= 3)
            {
                MessageBox.Show("Look at how the variables are declared in the programming example"); //Add Hit 
            } else if (counter >= 6)
            {
                MessageBox.Show("It seems like this question is causing trouble");//Add more text
            }
                text = tb_4.Text;
            if (text.Contains("Int") && text.Contains("Num1") && text.Contains(",") && text.Contains("Num2") && text.Contains(";") && text.Contains("String") && text.Contains("String1") && text.Contains(",") && text.Contains("String2") && text.Contains(";"))         
                {
                tabControl1.SelectTab(11);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(8, 9);
                    User.Exp();
                    
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(8, 9);
                    User.Exp2();
                   
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(8, 9);
                    User.Exp3();
                    
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(8, 9);
                    User.Exp4();
                    
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void TabPage11_Click(object sender, EventArgs e)
        {

        }

        private void Button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(12);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

       

        private void Button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(13);
        }

        

        private void Button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(14);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(12);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(16);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(15);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(13);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            string text;
            counter = 0;
            counter++;
            if (counter >= 3)
            {
                MessageBox.Show("Look at how the variables are declared in the programming example"); //Add Hit 
            }
            else if (counter >= 6)
            {
                MessageBox.Show("It seems like this question is causing trouble");//Add more text
            }
            text = textBox4.Text;
            if (text.Contains("string") && text.Contains("ExampleString") && text.Contains(";") && text.Contains("ExampleString") && text.Contains("=") && text.Contains("Console") && text.Contains(".") && text.Contains("readLine") && text.Contains("()") && text.Contains(";") | text.Contains("string") && text.Contains("ExampleString") && text.Contains(";") && text.Contains("ExampleString") && text.Contains("=") && text.Contains("Console.readLine();"))
            {
                tabControl1.SelectTab(17);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(9, 10);
                    User.Exp();

                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(9, 10);
                    User.Exp2();

                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(9, 10);
                    User.Exp3();

                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(9, 10);
                    User.Exp4();

                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }
        #region more buttons 
        private void TabPage13_Click(object sender, EventArgs e)
        {

        }

        private void Button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(18);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(19);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(14);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(15);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(16);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(17);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(18);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(19);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(21);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(20);
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(22);
        }
        #endregion

        private void Button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(20);
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(21);
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(23);
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(22);
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(24);
        }

        private void TabPage25_Click(object sender, EventArgs e)
        {

        }

        private void Button39_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(23);
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(25);
        }

        private void Button41_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(26);
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(27);
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(24);
        }

        private void Button44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(25);
        }

        private void Button46_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(26);
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(27);
        }

        private void Button47_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(29);
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(28);
        }

        private void Button49_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(30);
        }

        private void TabPage30_Click(object sender, EventArgs e)
        {

        }

        private void Button52_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(29);
        }

        private void Button51_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(31);
        }

        private void Button53_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(30);
        }

        private void Button54_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(32);
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(28);
        }
    }
}

