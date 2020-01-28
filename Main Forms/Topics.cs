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

        #region Declared Variables
        string currentlevel;
        introduction T = new introduction();
        Question_Forms.simpledata S = new Question_Forms.simpledata();
        #endregion

        public Topics()
        {
            InitializeComponent();
            
        }
       

        #region Change Tab Methods 
        private void ChangeTab(int tab)
        {
            
            T.tabControl1.SelectTab(tab);
            T.ShowDialog();
            this.Close();

        }
        private void ChangeTabSimple(int tab)
        {
            S.tabControl1.SelectTab(tab);
            S.ShowDialog();
            this.Close();
        }
        #endregion

        #region Random UI Unused Methods
        private void Topics_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Exit Button 
        /// <summary>
        /// Exit Button that exists the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #region Home Button 

        /// <summary>
        /// Home Button that brings user to the home page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        #endregion

        #region Introduction Page Button 

        private void Intro_btn_Click(object sender, EventArgs e)
        {
            //Statement used to check what user is logged in
            if ((string)this.pictureBox1.Tag == "user1")
            {
                
                
             
                //The picture box of current instance is set to image of user 
                T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                T.pictureBox1.Tag = "user1";
                
                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("levelfile.txt");
                int x = Int32.Parse(currentlevel);

                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
               
                    switch (x)
                    {
                        case 0:
                        this.Hide();
                        ChangeTab(0);                       
                        break;
                        case 1:
                        this.Hide();
                        ChangeTab(2);                      
                        break;
                        case 2:
                        this.Hide();
                        ChangeTab(4);                    
                        break;
                        case 3:
                        this.Hide();
                        ChangeTab(6);
                       
                        break;
                        default:
                            MessageBox.Show("Completed this section");
                            break;
                    }               
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                
              
                //The picture box of current instance is set to image of current user 
                T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                T.pictureBox1.Tag = "user2";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user2level.txt");
                int x = Int32.Parse(currentlevel);

                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 0:
                        this.Hide();
                        ChangeTab(0);
                        break;
                    case 1:
                        this.Hide();
                        ChangeTab(2);
                        break;
                    case 2:
                        this.Hide();
                        ChangeTab(4);
                        break;
                    case 3:
                        this.Hide();
                        ChangeTab(6);
                        break;
                    default:
                        MessageBox.Show("Completed this section");
                        break;
                }                
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                

                //The picture box of current instance is set to image of current user 
                T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                T.pictureBox1.Tag = "user3";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user3level.txt");
                int x = Int32.Parse(currentlevel);

                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 0:
                        this.Hide();
                        ChangeTab(0);
                        break;
                    case 1:
                        this.Hide();
                        ChangeTab(2);
                        break;
                    case 2:
                        this.Hide();
                        ChangeTab(4);
                        break;
                    case 3:
                        this.Hide();
                        ChangeTab(6);
                        break;
                    default:
                        MessageBox.Show("Completed this section");
                        break;
                }
                
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                //Hides Current Form 
                
                //The picture box of current instance is set to image of current user 
                T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                T.pictureBox1.Tag = "user4";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user4level.txt");
                int x = Int32.Parse(currentlevel);


                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 0:
                        this.Hide();
                        ChangeTab(0);
                        break;
                    case 1:
                        this.Hide();
                        ChangeTab(2);
                        break;
                    case 2:
                        this.Hide();
                        ChangeTab(4);
                        break;
                    case 3:
                        this.Hide();
                        ChangeTab(6);
                        break;
                    default:
                        MessageBox.Show("Completed this section");
                        break;
                }
                
            }
        }

        #endregion

        #region Creating Programs 

        private void Cp_btn_Click(object sender, EventArgs e)
        {
            
            //If statement to check if the forms picture box contains a certain image 
            if ((string)this.pictureBox1.Tag == "user1")
            {
                
                currentlevel = File.ReadAllText("levelfile.txt");
                int x = Int32.Parse(currentlevel);

                if ( x < 10 )
                {
                    MessageBox.Show("Not Completed the Previous Section");
                }
                //Add Code to Open up The form for this button and load the data for this user 
                
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                currentlevel = File.ReadAllText("levelfile.txt");
                int x = Int32.Parse(currentlevel);

                if (x > 10)
                {
                    MessageBox.Show("Not Completed the Previous Section");
                }
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                currentlevel = File.ReadAllText("levelfile.txt");
                int x = Int32.Parse(currentlevel);

                if (x > 10)
                {
                    MessageBox.Show("Not Completed the Previous Section");
                }
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                //Add Code to Open up The form for this button and load the data for this user 
                this.Close();
            }
        }

        #endregion 

        #region User Page Button 
        /// <summary>
        /// Button to open the users profile, four if statements to see which user is logged in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void user_btn_Click(object sender, EventArgs e)
        {                      
            if ((string)this.pictureBox1.Tag == "user1")
            {
                this.Hide();

                currentlevel = File.ReadAllText("levelfile.txt");
                UserProfile UserProfile1 = new UserProfile();
                UserProfile1.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                UserProfile1.pictureBox1.Tag = "user1";
                UserProfile1.name_lb.Text =  "User 1";
                UserProfile1.level.Text = currentlevel;
                UserProfile1.exp.Text = File.ReadAllText("exp1.txt");
                
                int x = Int32.Parse(currentlevel);

                if (x >= 3)
                {
                    UserProfile1.pictureBox2.Image = Properties.Resources.medal;
                    
                }
                if (x >= 4)
                {

                    UserProfile1.pictureBox6.Image = Properties.Resources.award;
                }

                UserProfile1.ShowDialog();

                this.Close();
            }      
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                currentlevel = File.ReadAllText("user2level.txt");
                UserProfile UserProfile2 = new UserProfile();
                UserProfile2.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                UserProfile2.pictureBox1.Tag = "user2";
                UserProfile2.name_lb.Text = "User 2";
                UserProfile2.level.Text = File.ReadAllText("user2level.txt");
                UserProfile2.exp.Text = File.ReadAllText("exp2.txt");
                int x = Int32.Parse(currentlevel);
                if (x >= 3)
                {
                    UserProfile2.pictureBox2.Image = Properties.Resources.medal;
                    
                    
                }
                if ( x >= 4)
                {
                    
                    UserProfile2.pictureBox6.Image = Properties.Resources.award;
                }
                UserProfile2.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                currentlevel = File.ReadAllText("user3level.txt");
                UserProfile UserProfile3 = new UserProfile();
                UserProfile3.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                UserProfile3.pictureBox1.Tag = "user3";
                UserProfile3.name_lb.Text = "User 3";
                UserProfile3.level.Text = File.ReadAllText("user3level.txt");
                UserProfile3.exp.Text = File.ReadAllText("exp3.txt");
                int x = Int32.Parse(currentlevel);
                if (x >= 3)
                {
                    UserProfile3.pictureBox2.Image = Properties.Resources.medal;
                   
                }
                if (x >= 4)
                {

                    UserProfile3.pictureBox6.Image = Properties.Resources.award;
                }
                UserProfile3.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                currentlevel = File.ReadAllText("user4level.txt");
                UserProfile UserProfile4 = new UserProfile();
                UserProfile4.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                UserProfile4.pictureBox1.Tag = "user4";
                UserProfile4.name_lb.Text = "User 4";
                UserProfile4.level.Text = File.ReadAllText("user4level.txt");
                UserProfile4.exp.Text = File.ReadAllText("exp4.txt");
                int x = Int32.Parse(currentlevel);
                if (x >= 3)
                {
                    UserProfile4.pictureBox2.Image = Properties.Resources.medal;                  
                }
                if (x >= 4)
                {
                    UserProfile4.pictureBox6.Image = Properties.Resources.award;
                }
                UserProfile4.ShowDialog();
                this.Close();
            }
        }

        #endregion

        #region Picture Box Clicks

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        #endregion 

        #region Simple Data Page Button 
        private void Sdp_btn_Click(object sender, EventArgs e)
        {
            if ((string)this.pictureBox1.Tag == "user1")
            {
                
                
                //The picture box of current instance is set to image of user 
                S.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                S.pictureBox1.Tag = "user1";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("levelfile.txt");
                int x = Int32.Parse(currentlevel);

                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 4:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(0);
                        break;
                    case 5:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(3);
                        break;
                    case 6:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(6);
                        break;
                    case 7:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(7);
                        break;
                    default:
                        MessageBox.Show("Complete Previous Section");
                        break;
                }

                
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                

                //Creates new instance of introduction form 
               

                //The picture box of current instance is set to image of current user 
                S.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                S.pictureBox1.Tag = "user2";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user2level.txt");
                int x = Int32.Parse(currentlevel);

                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 4:
                        this.Hide();
                        ChangeTabSimple(0);
                        break;
                    case 5:
                        this.Hide();
                        ChangeTabSimple(2);
                        break;
                    case 6:
                        this.Hide();
                        ChangeTabSimple(4);
                        break;
                    case 7:
                        this.Hide();
                        ChangeTabSimple(6);
                        break;
                    default:
                        MessageBox.Show("Completed this section");
                        break;
                }
                
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user3")
            {
               
                //Creates new instance of introduction form 
                

                //The picture box of current instance is set to image of current user 
                S.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                S.pictureBox1.Tag = "user3";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user3level.txt");
                int x = Int32.Parse(currentlevel);

                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 4:
                        this.Hide();
                        ChangeTabSimple(0);
                        break;
                    case 5:
                        this.Hide();
                        ChangeTabSimple(2);
                        break;
                    case 6:
                        this.Hide();
                        ChangeTabSimple(4);
                        break;
                    case 7:
                        this.Hide();
                        ChangeTabSimple(6);
                        break;
                    default:
                        MessageBox.Show("Completed this section");
                        break;
                }
                this.Close();
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user4")
            {
               
                //Creates new instance of introduction form 
                

                //The picture box of current instance is set to image of current user 
                S.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                S.pictureBox1.Tag = "user4";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user4level.txt");
                int x = Int32.Parse(currentlevel);


                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 4:
                        this.Hide();
                        ChangeTabSimple(0);
                        break;
                    case 5:
                        this.Hide();
                        ChangeTabSimple(2);
                        break;
                    case 6:
                        this.Hide();
                        ChangeTabSimple(4);
                        break;
                    case 7:
                        this.Hide();
                        ChangeTabSimple(6);
                        break;
                    default:
                        MessageBox.Show("Completed this section");
                        break;
                }
                
            }
        }

        #endregion

        #region End Game Button 
        private void Button1_Click(object sender, EventArgs e)
        {
            
            string currentlevel; 
            currentlevel = File.ReadAllText("levelfile.txt");
            int x = Int32.Parse(currentlevel);
            if (x >= 50)
            {
                //Open Form  
            } else
            {
                MessageBox.Show("Please Reach Level 50 warrior");
            }
        }

        #endregion

        

        private void Button1_Click_1(object sender, EventArgs e)
        {            
            Achievements Ach = new Achievements();
                   
            if ((string)this.pictureBox1.Tag == "user1")
            {
                
                this.Hide();
                Ach.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                Ach.pictureBox1.Tag = "user1";
                currentlevel = File.ReadAllText("levelfile.txt");
                int x = Int32.Parse(currentlevel);

                if (x >= 3)
                {
                    Ach.lb1.Text = "Badge Collector! - Achieved their first badge";
                }
                if (x >= 4)
                {
                    Ach.lb2.Text = "Getting the Basics! – Completed the introduction of the tutor system";
                }
                if (x >= 7)
                {
                    Ach.lb3.Text = "Problem Fixer! – Completed the first missing code problem ";
                }
                Ach.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                Ach.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                Ach.pictureBox1.Tag = "user2";
                currentlevel = File.ReadAllText("user2level.txt");
                int x = Int32.Parse(currentlevel);

                if (x >= 3)
                {
                    Ach.lb1.Text = "Badge Collector! - Achieved their first badge";
                }
                if (x >= 4)
                {
                    Ach.lb2.Text = "Getting the Basics! – Completed the introduction of the tutor system";
                }
                if (x >= 7)
                {
                    Ach.lb3.Text = "Problem Fixer! – Completed the first missing code problem ";
                }
                Ach.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                Ach.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                Ach.pictureBox1.Tag = "user3";
                currentlevel = File.ReadAllText("user3level.txt");
                int x = Int32.Parse(currentlevel);

                if (x >= 3)
                {
                    Ach.lb1.Text = "Badge Collector! - Achieved their first badge";
                }
                if (x >= 4)
                {
                    Ach.lb2.Text = "Getting the Basics! – Completed the introduction of the tutor system";
                }
                if (x >= 7)
                {
                    Ach.lb3.Text = "Problem Fixer! – Completed the first missing code problem ";
                }
                Ach.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                Ach.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                Ach.pictureBox1.Tag = "user4";
                currentlevel = File.ReadAllText("user4level.txt");
                int x = Int32.Parse(currentlevel);

                if (x >= 3)
                {
                    Ach.lb1.Text = "Badge Collector! - Achieved their first badge";
                }
                if (x >= 4)
                {
                    Ach.lb2.Text = "Getting the Basics! – Completed the introduction of the tutor system";
                }
                if (x >= 7)
                {
                    Ach.lb3.Text = "Problem Fixer! – Completed the first missing code problem ";
                }
                Ach.ShowDialog();
                this.Close();
            }
        }
    }
}
