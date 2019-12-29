using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tutoring_Project
{
    public partial class Userpage : Form
    {
        public Userpage()
        {
            InitializeComponent();
        }
        
        private void User1_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics T = new Topics();            
            T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
            T.pictureBox1.Tag = "user1";
            T.ShowDialog();
           
            
            this.Close();
        }

        private void User2_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics T = new Topics();
            T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
            T.pictureBox1.Tag = "user2";
            
            T.ShowDialog();
            this.Close();
        }

        private void User3_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics T = new Topics();
            T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
            T.pictureBox1.Tag = "user3";
            T.ShowDialog();
            this.Close();
        }

        private void User4_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics T = new Topics();
            T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
            T.pictureBox1.Tag = "user4";
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

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void Userpage_Load(object sender, EventArgs e)
        {

        }
    }
}
