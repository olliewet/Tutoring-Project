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

        private void Exp()
        {
            try
            {
                string exp = File.ReadAllText("exp1.txt");
                int x = int.Parse(exp);
                x = x + 10;
                exp = x.ToString();
                File.WriteAllText("exp1.txt", exp);
            }
            catch
            {
                MessageBox.Show("Error With the File");
            }
        }

        private void Exp2()
        {
            try
            {
                string exp = File.ReadAllText("exp2.txt");
                int x = int.Parse(exp);
                x = x + 10;
                exp = x.ToString();
                File.WriteAllText("exp2.txt", exp);
            }
            catch
            {
                MessageBox.Show("Error With the File");
            }
        }

        private void Exp3()
        {
            try
            {
                string exp = File.ReadAllText("exp3.txt");
                int x = int.Parse(exp);
                x = x + 10;
                exp = x.ToString();
                File.WriteAllText("exp3.txt", exp);
            }
            catch
            {
                MessageBox.Show("Error With the File");
            }
        }

        private void Exp4()
        {
            try
            {
                string exp = File.ReadAllText("exp4.txt");
                int x = int.Parse(exp);
                x = x + 10;
                exp = x.ToString();
                File.WriteAllText("exp4.txt", exp);
            }
            catch
            {
                MessageBox.Show("Error With the File");
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
                    Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("0", "1");
                    File.WriteAllText("user2level.txt", text);
                    Exp2();                   
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("0", "1");
                    File.WriteAllText("user3level.txt", text);
                    Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("0", "1");
                    File.WriteAllText("user4level.txt", text);
                    Exp4();
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
                    Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("1", "2");
                    File.WriteAllText("user2level.txt", text);
                    Exp2();
                } else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("1", "2");
                    File.WriteAllText("user3level.txt", text);
                    Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("1", "2");
                    File.WriteAllText("user4level.txt", text);
                    Exp4();
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
                    Exp();
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("2", "3");
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    File.WriteAllText("user2level.txt", text);
                    Exp2();
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("2", "3");
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    File.WriteAllText("user3level.txt", text);
                    Exp3();
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("2", "3");
                    MessageBox.Show("Well Done, Achievement and Badge Unlocked!");
                    File.WriteAllText("user4level.txt", text);
                    Exp4();
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
                Exp();
                T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                T.pictureBox1.Tag = "user1";             
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                string text = File.ReadAllText("user2level.txt");
                text = text.Replace("3", "4");
                File.WriteAllText("user2level.txt", text);
                Exp2();
                T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                T.pictureBox1.Tag = "user2";
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                string text = File.ReadAllText("user3level.txt");
                text = text.Replace("3", "4");
                File.WriteAllText("user3level.txt", text);
                Exp3();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                T.pictureBox1.Tag = "user3";               
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                string text = File.ReadAllText("user4level.txt");
                text = text.Replace("3", "4");
                File.WriteAllText("user4level.txt", text);
                Exp4();
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
    }
    
}
