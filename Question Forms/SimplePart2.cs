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
    }
}
