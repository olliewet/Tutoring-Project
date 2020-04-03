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
    public partial class Interactive_Code : Form
    {
        public Interactive_Code()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string A1 = comboBox1.SelectedItem.ToString();
            string A2 = comboBox2.SelectedItem.ToString();
            string A3 = comboBox3.SelectedItem.ToString();
            string A4 = comboBox4.SelectedItem.ToString();

                    
            if (A1.Equals("int value1 = 5;") && A2.Equals("int value2 = 10;") && A3.Equals("int Answer = Value1 + Value2;") && A4.Equals("Console.WriteLine(Answer);"))
            {
                richTextBox1.Text = "15";
            }
            else if (A1.Equals("int value1 = 5;") && A2.Equals("int value2 = 10;") && A3.Equals("int Answer = Value1 * Value2;") && A4.Equals("Console.WriteLine(Answer);"))
            {
                richTextBox1.Text = "50";
            }
            else if (A1.Equals("string Foo = \"A\";") && A2.Equals("string Foo = \"A\";") && A3.Equals("if (Foo == Bar) ") && A4.Equals("{ Console.WriteLine(Foo); }"))
            {
                richTextBox1.Text = "A";
            }
            else if (A1.Equals("string Foo = \"B\";") && A2.Equals("string Foo = \"B\";") && A3.Equals("if (Foo == Bar) ") && A4.Equals("{ Console.WriteLine(Foo); }"))
            {
                richTextBox1.Text = "B";
            }
            else if (A1.Equals("string Foo = \"A\";") && A2.Equals("string Foo = \"A\";") && A3.Equals("if(Foo = Bar)") && A4.Equals("{ Console.WriteLine(Foo); }"))
            {
                richTextBox1.Text = "Error";
                MessageBox.Show("Common Programming Misconception, this would cause an error because your assigning the value of bar to foo, inside of comparing the two values always use ==");
            }
            else if (A1.Equals("string Foo = \"B\";") && A2.Equals("string Foo = \"B\";") && A3.Equals("if(Foo = Bar)") && A4.Equals("{ Console.WriteLine(Foo); }"))
            {
                richTextBox1.Text = "Error";
                MessageBox.Show("Common Programming Misconception, this would cause an error because your assigning the value of bar to foo, inside of comparing the two values always use ==");
            }
            else
            {
                richTextBox1.Text = "Error";
            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Interactive_Code_Load(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
