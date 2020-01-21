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

        private void Topics_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userpage T = new Userpage();
            T.ShowDialog();
            this.Close();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (btn_3.Checked)
            {
                tabControl1.SelectTab(2);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                                     
                    string text = File.ReadAllText("levelfile.txt");
                    text = text.Replace("0", "1");
                    File.WriteAllText("levelfile.txt", text);

                    // Semi Implemented Experience 
                    // Come Back to at a later date  
                    // if statement to see what level they would be if x is between 100 and 200 level 2 
                    string texttest = File.ReadAllText("test.txt");
                    int x = int.Parse(texttest);
                    x = x + 10;                   
                    texttest = x.ToString();


                    File.WriteAllText("test.txt", texttest);

                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("0", "1");

                    File.WriteAllText("user2level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("0", "1");

                    File.WriteAllText("user3level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("0", "1");

                    File.WriteAllText("user4level.txt", text);
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

        private void Button4_Click(object sender, EventArgs e)
        {

            if (radioButton7.Checked)
            {
                tabControl1.SelectTab(4);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    string text = File.ReadAllText("levelfile.txt");
                    text = text.Replace("1", "2");

                    File.WriteAllText("levelfile.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("1", "2");

                    File.WriteAllText("user2level.txt", text);
                } else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("1", "2");

                    File.WriteAllText("user3level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("1", "2");

                    File.WriteAllText("user4level.txt", text);
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

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                tabControl1.SelectTab(6);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    string text = File.ReadAllText("levelfile.txt");
                    text = text.Replace("2", "3");
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    File.WriteAllText("levelfile.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("2", "3");
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    File.WriteAllText("user2level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("2", "3");
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    File.WriteAllText("user3level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("2", "3");
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    File.WriteAllText("user4level.txt", text);
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Topics T = new Topics();
            if ((string)this.pictureBox1.Tag == "user1")
            {
                string text = File.ReadAllText("levelfile.txt");
                text = text.Replace("3", "4");
                File.WriteAllText("levelfile.txt", text);                         
                T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                T.pictureBox1.Tag = "user1";             
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                string text = File.ReadAllText("user2level.txt");
                text = text.Replace("3", "4");
                File.WriteAllText("user2level.txt", text);
                T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                T.pictureBox1.Tag = "user2";
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                string text = File.ReadAllText("user3level.txt");
                text = text.Replace("3", "4");
                T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                T.pictureBox1.Tag = "user3";
                File.WriteAllText("user3level.txt", text);
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                string text = File.ReadAllText("user4level.txt");
                text = text.Replace("3", "4");
                File.WriteAllText("user4level.txt", text);
                T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                T.pictureBox1.Tag = "user4";
            }
            this.Close();
            T.ShowDialog();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
