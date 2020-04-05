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

        #region counters
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
     
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
            counter1++;
            if (counter1 >= 3)
            {
                MessageBox.Show("Remember the structure of an assigenment statement, remember the difference = and ==, the single = should be used in this instance"); //Add Hit 
            }
            else if (counter1 >= 6)
            {
                MessageBox.Show("Example of an assigenment statement Double PreciseNumberOfDrinks = 5.1 ; ");
            }
            text = tb_4.Text;
            text = text.ToLower();
            if (text.StartsWith("int") && text.Contains("numberofdrinks") && text.Contains("=") && text.Contains("5") && text.Contains(";") | text.Contains("int") && text.Contains("numberofdrinks") && text.Contains("=") && text.EndsWith("5;"))
            {
                MessageBox.Show("Achievement Unlocked!");
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
            
            counter2++;
            if (counter2 == 3)
            {
                MessageBox.Show("Please refer back to the information on the previous slide as help!");
            }
            else if (counter2 == 6)
            {
                MessageBox.Show("It seems like you many be struggling, double is able to hold a value of up to 15 digits");
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
          
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
           
            counter3++;
            if (counter3 == 3)
            {
                MessageBox.Show("This question requires the user to place in the correct words and phases in the correct textboxes to make the code work!"); //Add Hit 
            }
            else if (counter3 == 5)
            {
                MessageBox.Show("Remember that the variables require a type before the variable name!");
            }

            string A1 = answer1.SelectedItem.ToString();
            string A2 = answer2.SelectedItem.ToString();
            string A3 = answer3.SelectedItem.ToString();
            string A4 = answer4.SelectedItem.ToString();

           

            if (A1.Equals("double") && A2.Equals("string") && A3.Equals("Console.ReadLine();") && A4.Equals("Console.WriteLine"))
            {                
                MessageBox.Show("Achievement Unlocked!");
                tabControl1.SelectTab(13);
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

        private void Button25_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(11);
        }

        private void Finish_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics T = new Topics();
            MessageBox.Show("Achievement Unlocked!");
            if ((string)this.pictureBox1.Tag == "user1")
            {
                User.User1(16, 17);
                User.Exp();
                T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                T.pictureBox1.Tag = "user1";
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                User.User2(16, 17);
                User.Exp2();
                T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                T.pictureBox1.Tag = "user2";
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                User.User3(16, 17);
                User.Exp3();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                T.pictureBox1.Tag = "user3";
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                User.User4(16, 17);
                User.Exp4();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                T.pictureBox1.Tag = "user4";
            }
            this.Close();
            T.ShowDialog();
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(12); 
        }

        private void RichTextBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}