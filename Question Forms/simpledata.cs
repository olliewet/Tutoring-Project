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
            this.Hide();
            Userpage T = new Userpage();
            T.ShowDialog();
            this.Close();
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

        private void Conobj_btn_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                tabControl1.SelectTab(3);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    string text = File.ReadAllText("levelfile.txt");
                    text = text.Replace("4", "5");

                    File.WriteAllText("levelfile.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("4", "5");

                    File.WriteAllText("user2level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("4", "5");

                    File.WriteAllText("user3level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("4", "5");

                    File.WriteAllText("user4level.txt", text);
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Conquestion2_btn_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                tabControl1.SelectTab(4);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    string text = File.ReadAllText("levelfile.txt");
                    text = text.Replace("5", "6");

                    File.WriteAllText("levelfile.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("5", "6");

                    File.WriteAllText("user2level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("5", "6");

                    File.WriteAllText("user3level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("5", "6");

                    File.WriteAllText("user4level.txt", text);
                }
            }
            else
            {
                MessageBox.Show("Answer is incorrect");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           


            if (textBox1.Text.Equals("static") | (textBox1.Text.Equals("Static") && textBox2.Text.Equals("void") | textBox2.Text.Equals("Void") && textBox3.Text.Equals("Main()") | textBox3.Text.Equals("main()")))
            {
                tabControl1.SelectTab(6);
                if ((string)this.pictureBox1.Tag == "user1")
                {
                    string text = File.ReadAllText("levelfile.txt");
                    text = text.Replace("6", "7");

                    File.WriteAllText("levelfile.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user2")
                {
                    string text = File.ReadAllText("user2level.txt");
                    text = text.Replace("6", "7");

                    File.WriteAllText("user2level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user3")
                {
                    string text = File.ReadAllText("user3level.txt");
                    text = text.Replace("6", "7");

                    File.WriteAllText("user3level.txt", text);
                }
                else if ((string)this.pictureBox1.Tag == "user4")
                {
                    string text = File.ReadAllText("user4level.txt");
                    text = text.Replace("6", "7");

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

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
