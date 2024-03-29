﻿using System;
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

        #region User 1 
        private void User1_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            string name = "user1";
            Topics T = new Topics(name);            
            T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
            T.pictureBox1.Tag = "user1";
            
            T.ShowDialog();
            this.Close();
        }
        #endregion
        
        #region User 2 
        private void User2_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            string name = "user2";
            Topics T = new Topics(name);
            T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
            T.pictureBox1.Tag = "user2";
           
            T.ShowDialog();
            this.Close();
        }
        #endregion

        #region User 3 
        private void User3_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            string name = "user3";
            Topics T = new Topics(name);
            T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
            T.pictureBox1.Tag = "user3";
            
            T.ShowDialog();
            this.Close();
        }
        #endregion

        #region User 4 
        private void User4_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            string name = "user4";
            Topics T = new Topics(name);
            T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
            T.pictureBox1.Tag = "user4";
            
            T.ShowDialog();
            this.Close();
        }
        #endregion

        #region Home and Exit Buttons
        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
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
        #endregion

        #region Unused Buttons 
        private void Userpage_Load(object sender, EventArgs e)
        {

        }

        private void Name_lb_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
