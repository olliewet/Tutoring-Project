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
            
            if (radioButton3.Checked)
            {
                tabControl1.SelectTab(2);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    string text = File.ReadAllText("levelfile.txt");
                    text = text.Replace("0", "1");

                    File.WriteAllText("levelfile.txt", text);
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
            
            if (radioButton12.Checked)
            {
                tabControl1.SelectTab(6);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    string text = File.ReadAllText("levelfile.txt");
                    text = text.Replace("2", "3");

                    File.WriteAllText("levelfile.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("2", "3");

                    File.WriteAllText("user2level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("2", "3");

                    File.WriteAllText("user3level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("2", "3");

                    File.WriteAllText("user4level.txt", text);
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }
    }
}
