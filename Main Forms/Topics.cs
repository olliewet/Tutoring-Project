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
        Achievements Ach = new Achievements();
        UserProfile UserProfiles = new UserProfile();
        Question_Forms.simpledata S = new Question_Forms.simpledata();
        Question_Forms.SimplePart2 S2 = new Question_Forms.SimplePart2();
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

        private void ChangeTabSimplePart2(int tab)
        {
            S2.tabControl1.SelectTab(tab);
            S2.ShowDialog();
            this.Close();
        }

        private void CompleteIntroductionSection (int x)
        {
            if (x < 4)
            {
                MessageBox.Show("Complete Previous Section");
            }
        }

        private void CompleteSimpleDataSection(int x)
        {
            if (x < 4)
            {
                MessageBox.Show("Complete Introduction");
            }
            else if ( x < 13)
            {
                MessageBox.Show("Complete Simple Data Section");
            }
        }
        #endregion

        private void Achievements(int x)
        {           
            if (x >= 3)
            {                
                Ach.pictureBox2.Image = Properties.Resources.BadgeCollector;
            }
            if (x >= 4)
            {
                Ach.pictureBox3.Image = Properties.Resources.Basics;               
            }
            if (x >= 7)
            {
                Ach.pictureBox4.Image = Properties.Resources.ProblemSolver;              
            }
        }

        private void Badges(int x)
        {
            if (x >= 3)
            {
                UserProfiles.pictureBox2.Image = Properties.Resources.medal;

            }

            if (x >= 4)
            {

                UserProfiles.pictureBox6.Image = Properties.Resources.award;
            }
        }


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

                if ( x < 16)
                {
                    MessageBox.Show("Not Completed the Previous Section");
                }
                //Add Code to Open up The form for this button and load the data for this user 
                
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                currentlevel = File.ReadAllText("user2level.txt");
                int x = Int32.Parse(currentlevel);

                if (x > 16)
                {
                    MessageBox.Show("Not Completed the Previous Section");
                }
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                currentlevel = File.ReadAllText("user3level.txt");
                int x = Int32.Parse(currentlevel);

                if (x > 16)
                {
                    MessageBox.Show("Not Completed the Previous Section");
                }
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {

                this.Hide();
                currentlevel = File.ReadAllText("user4level.txt");
                int x = Int32.Parse(currentlevel);

                if (x > 16)
                {
                    MessageBox.Show("Not Completed the Previous Section");
                }
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

                UserProfiles.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                UserProfiles.pictureBox1.Tag = "user1";
                UserProfiles.name_lb.Text =  "User 1";
                UserProfiles.level.Text = currentlevel;
                UserProfiles.exp.Text = File.ReadAllText("exp1.txt");              
                int x = Int32.Parse(currentlevel);
                Badges(x);
                UserProfiles.ShowDialog();
                this.Close();
            }      
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                currentlevel = File.ReadAllText("user2level.txt");

                UserProfiles.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                UserProfiles.pictureBox1.Tag = "user2";
                UserProfiles.name_lb.Text = "User 2";
                UserProfiles.level.Text = File.ReadAllText("user2level.txt");
                UserProfiles.exp.Text = File.ReadAllText("exp2.txt");
                int x = Int32.Parse(currentlevel);
                Badges(x);
                UserProfiles.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                currentlevel = File.ReadAllText("user3level.txt");

                UserProfiles.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                UserProfiles.pictureBox1.Tag = "user3";
                UserProfiles.name_lb.Text = "User 3";
                UserProfiles.level.Text = File.ReadAllText("user3level.txt");
                UserProfiles.exp.Text = File.ReadAllText("exp3.txt");
                int x = Int32.Parse(currentlevel);
                Badges(x);
                UserProfiles.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                currentlevel = File.ReadAllText("user4level.txt");

                UserProfiles.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                UserProfiles.pictureBox1.Tag = "user4";
                UserProfiles.name_lb.Text = "User 4";
                UserProfiles.level.Text = File.ReadAllText("user4level.txt");
                UserProfiles.exp.Text = File.ReadAllText("exp4.txt");
                int x = Int32.Parse(currentlevel);
                Badges(x);
                UserProfiles.ShowDialog();
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
                CompleteIntroductionSection(x);
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
                    case 8:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(8);
                        break;
                    case 9:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(11);
                        break;
                    case 10:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(17);
                        break;
                    case 11:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(22);
                        break;
                    case 12:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(27);
                        break;
                    default:
                        MessageBox.Show("Completed Section");
                        break;
                }
               
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user2")
            {                            
                //The picture box of current instance is set to image of current user 
                S.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                S.pictureBox1.Tag = "user2";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user2level.txt");
                int x = Int32.Parse(currentlevel);

                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                CompleteIntroductionSection(x);
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
                    case 8:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(8);
                        break;
                    case 9:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(11);
                        break;
                    case 10:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(17);
                        break;
                    case 11:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(22);
                        break;
                    case 12:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(27);
                        break;
                    default:
                        MessageBox.Show("Complete Previous Section");
                        break;
                }
                
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user3")
            {

                //The picture box of current instance is set to image of current user 
                S.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                S.pictureBox1.Tag = "user3";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user3level.txt");
                int x = Int32.Parse(currentlevel);
                CompleteIntroductionSection(x);
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
                    case 8:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(8);
                        break;
                    case 9:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(11);
                        break;
                    case 10:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(17);
                        break;
                    case 11:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(22);
                        break;
                    case 12:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(27);
                        break;
                    default:
                        MessageBox.Show("Complete Previous Section");
                        break;
                }
                
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                //The picture box of current instance is set to image of current user 
                S.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                S.pictureBox1.Tag = "user4";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user4level.txt");
                int x = Int32.Parse(currentlevel);
                CompleteIntroductionSection(x);
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
                    case 8:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(8);
                        break;
                    case 9:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(11);
                        break;
                    case 10:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(17);
                        break;
                    case 11:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(22);
                        break;
                    case 12:
                        this.Hide();
                        this.Close();
                        ChangeTabSimple(27);
                        break;
                    default:
                        MessageBox.Show("Complete Previous Section");
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

        

        private void Ach_button(object sender, EventArgs e)
        {            
          
            if ((string)this.pictureBox1.Tag == "user1")
            {
                
                this.Hide();
                Ach.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                Ach.pictureBox1.Tag = "user1";
                currentlevel = File.ReadAllText("levelfile.txt");
                int x = Int32.Parse(currentlevel);
                Achievements(x);
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
                Achievements(x);
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
                Achievements(x);               
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
                Achievements(x);               
                Ach.ShowDialog();
                this.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if ((string)this.pictureBox1.Tag == "user1")
            {
                //The picture box of current instance is set to image of user 
                S2.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                S2.pictureBox1.Tag = "user1";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("levelfile.txt");
                int x = Int32.Parse(currentlevel);
                CompleteSimpleDataSection(x);
                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 13:
                        this.Hide();
                        this.Close();
                        ChangeTabSimplePart2(0);
                        break;
                    case 14:
                        this.Hide();
                        this.Close();
                        ChangeTabSimplePart2(0);
                        break;
                    default:
                        MessageBox.Show("Complete Previous Section");
                        break;
                }


            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                //The picture box of current instance is set to image of current user 
                S2.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                S2.pictureBox1.Tag = "user2";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user2level.txt");
                int x = Int32.Parse(currentlevel);
                CompleteSimpleDataSection(x);
                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 13:
                        this.Hide();
                        this.Close();
                        ChangeTabSimplePart2(0);
                        break;
                    case 14:
                        this.Hide();
                        this.Close();
                        ChangeTabSimplePart2(0);
                        break;
                    default:
                        MessageBox.Show("Complete Previous Section");
                        break;
                }

            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user3")
            {

                //The picture box of current instance is set to image of current user 
                S2.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                S2.pictureBox1.Tag = "user3";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user3level.txt");
                int x = Int32.Parse(currentlevel);
                CompleteSimpleDataSection(x);
                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 13:
                        this.Hide();
                        this.Close();
                        ChangeTabSimplePart2(0);
                        break;
                    case 14:
                        this.Hide();
                        this.Close();
                        ChangeTabSimplePart2(0);
                        break;
                    default:
                        MessageBox.Show("Complete Previous Section");
                        break;
                }
                this.Close();
            }
            //Statement used to check what user is logged in
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                //The picture box of current instance is set to image of current user 
                S2.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                S2.pictureBox1.Tag = "user4";

                // Data from text file (users level) is parsed into int and stored within variable  
                currentlevel = File.ReadAllText("user4level.txt");
                int x = Int32.Parse(currentlevel);
                CompleteSimpleDataSection(x);

                //Saving and Loading Function 
                //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                switch (x)
                {
                    case 13:
                        this.Hide();
                        this.Close();
                        ChangeTabSimplePart2(0);
                        break;
                    case 14:
                        this.Hide();
                        this.Close();
                        ChangeTabSimplePart2(0);
                        break;
                    default:
                        MessageBox.Show("Complete Previous Section");
                        break;
                }

            }
        }
    }
}
