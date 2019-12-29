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
using Tutoring_Project.Properties;

namespace Tutoring_Project
{
    public partial class Topics : Form
    {
        List<User> _user1 = null;
        public Topics()
        {
            InitializeComponent();
            _user1 = new List<User>();
            _user1 = File.ReadAllLines("User1.csv")
                                        .Skip(1)
                                        .Select(v => User.FromCSV(v))
                                        .ToList();
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

        private void Topics_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click_1(object sender, EventArgs e)
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

        private void Intro_btn_Click(object sender, EventArgs e)
        {
            //If statement to check if the forms picture box contains a certain image 
            if ((string)this.pictureBox1.Tag == "user1")
            {

                this.Hide();
                introduction T = new introduction();
                T.ShowDialog();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                introduction T = new introduction();
                T.ShowDialog();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                introduction T = new introduction();
                T.ShowDialog();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                introduction T = new introduction();
                T.ShowDialog();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
        }

        private void Cp_btn_Click(object sender, EventArgs e)
        {
            //If statement to check if the forms picture box contains a certain image 
            if ((string)this.pictureBox1.Tag == "user1")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            
            //If statement to check if the forms picture box contains a certain image 
            if ((string)this.pictureBox1.Tag == "user1")
            {
                this.Hide();
                UserProfile UserProfile1 = new UserProfile();
                UserProfile1.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                UserProfile1.pictureBox1.Tag = "user1";
                UserProfile1.name_lb.Text =  "user1";
                UserProfile1.level.Text = File.ReadAllText("user1level.txt");

                UserProfile1.ShowDialog();

                this.Close();
            }      
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                UserProfile UserProfile2 = new UserProfile();
                UserProfile2.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                UserProfile2.pictureBox1.Tag = "user2";
                UserProfile2.name_lb.Text = "user 2";
                UserProfile2.level.Text = File.ReadAllText("user2level.txt");
                UserProfile2.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                UserProfile UserProfile3 = new UserProfile();
                UserProfile3.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                UserProfile3.pictureBox1.Tag = "user3";
                UserProfile3.name_lb.Text = "user 3";
                UserProfile3.level.Text = File.ReadAllText("user3level.txt");
                UserProfile3.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                UserProfile UserProfile4 = new UserProfile();
                UserProfile4.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                UserProfile4.pictureBox1.Tag = "user4";
                UserProfile4.name_lb.Text = "user 4";
                UserProfile4.level.Text = File.ReadAllText("user4level.txt");
                UserProfile4.ShowDialog();
                this.Close();
            }
        }


        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Sdp_btn_Click(object sender, EventArgs e)
        {
            //If statement to check if the forms picture box contains a certain image 
            if ((string)this.pictureBox1.Tag == "user1")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
