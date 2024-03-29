﻿using System;
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
    public partial class ProgramFlow : Form
    {
        public ProgramFlow()
        {
            InitializeComponent();
        }

        #region counters
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int counter5 = 0;   
        #endregion

        private void MessageBoxIf ()
        {
            MessageBox.Show("if (condition)" + "\n" + "statement or block we do if the condition is true" + "\n" + "\n" + "else" + "\n" + "statement or block we do if the condition is false");
        }
        private void ChangeUser()
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
        private void Topics_btn_Click(object sender, EventArgs e)
        {
            ChangeUser();
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

        private void Con_btn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBoxIf();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBoxIf();
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("if (true)" + "\n" + "    Console.WriteLine (\"Hello Mum\") ; ");
        }

        private void Button14_Click(object sender, EventArgs e)
        {            
            counter1++;
            if (counter1 == 3)
            {
                MessageBox.Show("IF statements can be followed by an else statement to specify a certain block of code to be executed!"); 
            }
            if (answer_btn1.Checked)
            {
                tabControl1.SelectTab(4);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(19, 20);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(19, 20);
                    User.Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(19, 20);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(19, 20);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            string text;
            
            counter2++;
            if (counter2 == 3)
            {
                MessageBox.Show("Read the question carefully, the question is asking the user to print a certain phase to the console when x is less than 10"); 
            }
           
            text = tb_4.Text;
            if (text.Contains("if (x < 10){Console.WriteLine(\"Hello World\");")) 
            {
                
                tabControl1.SelectTab(5);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(20, 21);
                    User.Exp();

                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(20, 21);
                    User.Exp2();

                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(20, 21);
                    User.Exp3();

                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(20, 21);
                    User.Exp4();

                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("equals.If the left hand side and the right hand side are equal the expression has the value true.If they are not equal the value is false."  + "\n" + "4 == 5 " + "\n" +  "- would evaluate to false.Note that it is not particularly meaningful to compare floating point variables to see if they hold exactly the same values.Because of the factthat they are held to limited precision you might find that conditions fail when they should not for example the following equation:" + "\n" + "x = 3.0 * (1.0 / 3.0) ;" + "\n" + "-may well result in x containing 0.99999999, which would mean that:" + "\n" + "-x == 1.0 " + "\n" + " - would be false - even though mathematically the test should evaluate to true ");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not equal. The reverse of equals. If the operands are not equal the expression has the value true, if they are equal it has the value false.Again, this test is not advisable for use with floating point numbers.");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("less than. If the operand on the left is less than the one on the right the value of the expression is true.If the left hand operand is larger than or equal to the right hand one the expression gives false.It is quite valid to compare floating point numbers in this way.");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("greater than. If the operand on the left is greater than the one on the right the result is true.If the operand on the left is less than or equal to the one on the right the result is false.");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("less than or equal to.If the operand on the left is less than or equal to the one on the right you get true, otherwise you get false.");

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("greater than or equal to. If the operand on the left is greater than or equal to the one on the right you get true, otherwise it is false.");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not. This can be used to invert a particular value or expression, for example you can say!true, which is false, or you could say: !(x == y) - which means the same as (x!= y).You use not when you want to invert the sense of an expression.");
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("&&" + "\n" + "and. If the operands on each side of the && are true the result of the && is true. If one of them is false the result is false, for example " + "\n" + "(width >= 0.5) && (width <= 5.0)" + "\n" + "- this would be true if the width was valid according to our above description. I’ve put brackets around each of the conditions in this example, so that it is easier to see what is going on. However, the compiler is able to work out that the && needs to be applied between the result of the two logical expressions, so they are not actually required.");
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("or. If either of the operands each side of the || are true the result of the expression is true.The expression is only false if both operands are false, for example:" + "\n" + "width < 0.5 || width > 5.0" + "\n" + "- this would be true if the width was invalid. We are saying that the width is invalid if it is less than the minimum or larger than the maximum.Note that to reverse the sense of the condition(i.e. true when the value is invalid) we not only have to change the > into <= in each expression, but also change the && into an ||." + "\n" + "Using these operators in conjunction with the if construction we can make decisions and change what our program will do in response to the data we get.");
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            
            counter3++;
            if (counter3 == 3)
            {
                MessageBox.Show("Look at the provided code, the value of the int will lead you to the answer of the question");
            }
            if (radioButton4.Checked)
            {
                tabControl1.SelectTab(7);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(21, 22);
                    User.Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(21, 22);
                    User.Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(21, 22);
                    User.Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(21, 22);
                    User.Exp4();
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            string text;
            
            counter4++;
            if (counter4 == 3)
            {
                MessageBox.Show("Please refer to the information on the previous page"); 
            }
            else if (counter4  == 6)
            {
                MessageBox.Show("It seems like you might be struggling with this question, remember num is an integer and not an array!");
            }
            text = textBox3.Text;
            if (text.Contains("do { Console.WriteLine(\"Value of i: {0}\", i); i++;} while (i < num);")) 
            { 
                tabControl1.SelectTab(11);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(22, 23);
                    User.Exp();

                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(22, 23);
                    User.Exp2();

                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(22, 23);
                    User.Exp3();

                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(22, 23);
                    User.Exp4();

                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(12);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(13);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(14);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Note that we are using two variables as switches, they do not hold values as such; they are actually used to represent states within the program as it runs.This is a standard programming trick that you will find very useful." + "\n" + "You can break out of any of the three kinds of loop. In every case the program continues running at the statement after the last statement of the loop.");

        }

        private void Button26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(15);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            string text;
            
            counter5++;
            if (counter5 == 3)
            {
                MessageBox.Show("Remember to look at the operator of the answer, and compare the operator to the question being asked, this should make the question easier to answer");  
            }
          
            text = textBox1.Text;
            if (text.Contains("for ( int i = 0; i < 100; i++ { Console.WriteLine(i); }")) 
            {

                tabControl1.SelectTab(16);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    User.User1(23, 24);
                    User.Exp();

                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    User.User2(23, 24);
                    User.Exp2();

                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    User.User3(23, 24);
                    User.Exp3();

                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    User.User4(23, 24);
                    User.Exp4();

                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

      

        private void Label16_Click(object sender, EventArgs e)
        {
            tb_4.Text = "if (x < 10){Console.WriteLine(\"Hello World\");";
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            tb_4.Text = "if (x < 10){PrintToConsole(); }";
        }

        private void Label18_Click(object sender, EventArgs e)
        {
            textBox3.Text = "do { Console.WriteLine(\"Value of i: {0}\", i); i++;} while (i < num.Length);";
        }

        private void Label15_Click(object sender, EventArgs e)
        {
            textBox3.Text = "do { Console.WriteLine(\"Value of i: {0}\", i); i++;} while (i < num);";
        }

        private void Label17_Click(object sender, EventArgs e)
        {
            textBox3.Text = "do { Console.WriteLine(i); i++;} while (i < num.Length);";
        }

        private void Label19_Click(object sender, EventArgs e)
        {
            textBox3.Text = "do { Console.WriteLine(\"Value of i: {0}\", i); i++;} while (i > num);";
        }

        private void Label23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "for ( int i = 0; i < 100; i++ { Console.WriteLine(i); }";
        }

        private void Label20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "for ( int i = 0; i > 100; i++ { Console.WriteLine(i); }";
        }

        private void Label21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "for ( int i = 0; i < 10; i++ { Console.WriteLine(i); }";
        }

        private void Simple_btn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Label14_Click(object sender, EventArgs e)
        {
            tb_4.Text = "if (x < 20){Console.WriteLine(\"Hello World\");";
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void Finish_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics T = new Topics();
            MessageBox.Show("Achievement Unlocked!");
            if ((string)this.pictureBox1.Tag == "user1")
            {
                User.User1(24, 25);
                User.Exp();
                T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                T.pictureBox1.Tag = "user1";
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                User.User2(24, 25);
                User.Exp2();
                T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                T.pictureBox1.Tag = "user2";
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                User.User3(24, 25);
                User.Exp3();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                T.pictureBox1.Tag = "user3";
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                User.User4(24, 25);
                User.Exp4();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                T.pictureBox1.Tag = "user4";
            }
            this.Close();
            T.ShowDialog();
        }

        private void ProgramFlow_Load(object sender, EventArgs e)
        {

        }

        private void Button28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(11);
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(12);
        }

        private void Button41_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(13);
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(14);
        }
    }
}
