﻿using System;
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
        Identifiers I = new Identifiers();
        Question_Forms.ProgramFlow PF = new Question_Forms.ProgramFlow();
        EndGame E = new EndGame();
        Question_Forms.Interactive_Code In = new Question_Forms.Interactive_Code();
        #endregion
        string user; 

        public Topics()
        {
            InitializeComponent();
        }

        public Topics(string name)
        {
            InitializeComponent();
            user = name; 
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
        private void ChangeTabID(int tab)
        {
            I.tabControl1.SelectTab(tab);
            I.ShowDialog();
            this.Close();
        }

        private void ChangeTabPF(int tab)
        {
            PF.tabControl1.SelectTab(tab);
            PF.ShowDialog();
            this.Close();
        }

        private void ChangeTabEnd()
        {            
            E.ShowDialog();
            this.Close();
        }

        private void inte()
        {
            In.ShowDialog();
            this.Close();
        }
        #endregion


        #region SwitchStatements
        private void SwitchStatementIntroduction(int x)
        {
            switch (x)
            {
                case 0:
                    this.Hide();
                    this.Close();
                    ChangeTab(0);
                    break;
                case 1:
                    this.Hide();
                    this.Close();
                    ChangeTab(2);
                    break;
                case 2:
                    this.Hide();
                    this.Close();
                    ChangeTab(4);
                    break;
                case 3:
                    this.Hide();
                    this.Close();
                    ChangeTab(6);
                    break;             
            }
        }
        private void SwitchStatementSimple(int x)
        {
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
            }

        }
        private void SwitchStatementSimplePart2(int x)
        {
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
                    ChangeTabSimplePart2(7);
                    break;
                case 15:
                    this.Hide();
                    this.Close();
                    ChangeTabSimplePart2(9);
                    break;               
            }
        }
        private void SwitchStatementID(int x)
        {
            switch (x)
            {               
                case 17:
                    this.Hide();
                    this.Close();
                    ChangeTabID(0);
                    break;
                case 18:
                    this.Hide();
                    this.Close();
                    ChangeTabID(6);
                    break;                               
            }
        }
        private void SwitchStatementPF(int x)
        {
            switch (x)
            {             
                case 19:
                    this.Hide();
                    this.Close();
                    ChangeTabPF(0);
                    break;
                case 20:
                    this.Hide();
                    this.Close();
                    ChangeTabPF(4);
                    break;
                case 21:
                    this.Hide();
                    this.Close();
                    ChangeTabPF(5);
                    break;
                case 22:
                    this.Hide();
                    this.Close();
                    ChangeTabPF(7);
                    break;
                case 23:
                    this.Hide();
                    this.Close();
                    ChangeTabPF(11);
                    break;
                case 24:
                    this.Hide();
                    this.Close();
                    ChangeTabPF(16);
                    break;
            }
        }

        private void SwitchEndGame(int x)
        {
            if (x > 24)
            {
                this.Hide();
                this.Close();
                ChangeTabEnd();
            }
        }

        private void SwitchInt(int x)
        {
            if (x >= 0)
            {
                this.Hide();
                this.Close();
                inte();
            }
        }
        #endregion

        #region Achievements and Badges Methods
        private void Achievements(int x)
        {
            if (x >= 3)
            {
                Ach.pictureBox2.Image = Properties.Resources.OllieBadge;
            }
            else if (x <= 3)
            {
                Ach.pictureBox2.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 4)
            {
                Ach.pictureBox3.Image = Properties.Resources.OllieBasics;
            }
            else if (x <= 4)
            {
                Ach.pictureBox3.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 7)
            {
                Ach.pictureBox4.Image = Properties.Resources.ProblemSolver;
            }
            else if (x <= 7)
            {
                Ach.pictureBox4.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 9)
            {
                Ach.pictureBox7.Image = Properties.Resources.Var;
            }
            else if (x <= 9)
            {
                Ach.pictureBox7.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 11)
            {
                Ach.pictureBox6.Image = Properties.Resources.Parse;
            }
            else if (x <= 11)
            {
                Ach.pictureBox6.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 13)
            {
                Ach.pictureBox5.Image = Properties.Resources.Part1;
            }
            else if (x <= 13)
            {
                Ach.pictureBox5.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 14)
            {
                Ach.pictureBox10.Image = Properties.Resources.num;
            }
            else if (x <= 14)
            {
                Ach.pictureBox10.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 16)
            {
                Ach.pictureBox9.Image = Properties.Resources.MasterSolver;
            }
            else if (x <= 16)
            {
                Ach.pictureBox9.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 17)
            {
                Ach.pictureBox8.Image = Properties.Resources.Part2;
            }
            else if (x <= 17)
            {
                Ach.pictureBox8.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 18)
            {
                Ach.pictureBox13.Image = Properties.Resources.IDAchieve;
            }
            else if (x <= 18)
            {
                Ach.pictureBox13.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 19)
            {
                Ach.pictureBox12.Image = Properties.Resources.CompID;
            }
            else if (x <= 19)
            {
                Ach.pictureBox12.Image = Properties.Resources.AchiNotUnlocked;
            }

            if (x >= 20)
            {
                Ach.pictureBox19.Image = Properties.Resources.IFAchieve;
            }
            else if (x <= 20)
            {
                Ach.pictureBox19.Image = Properties.Resources.AchiNotUnlocked;
            }
            if (x >= 22)
            {
                Ach.pictureBox18.Image = Properties.Resources.UIF;
            }
            else if (x <= 22)
            {
                Ach.pictureBox18.Image = Properties.Resources.AchiNotUnlocked;
            }
            if (x >= 25)
            {
                Ach.pictureBox17.Image = Properties.Resources.ProgAchieve;
            }
            else if (x <= 25)
            {
                Ach.pictureBox17.Image = Properties.Resources.AchiNotUnlocked;
            }

        }

        private void Badges(int x)
        {

            if (x >= 0 && x <= 200)
            {
                UserProfiles.pictureBox2.Image = Properties.Resources.bronze;
                UserProfiles.label1.Text = "Brozne"; 
            }
            else if (x >= 200 && x <= 400)
            {
               UserProfiles.pictureBox2.Image = Properties.Resources.silver;
               UserProfiles.label1.Text = "Silver";
            }
            else if (x >= 400 && x <= 700)
            {
                UserProfiles.pictureBox2.Image = Properties.Resources.gold;
                UserProfiles.label1.Text = "Gold";
            }
            else if (x >= 700 && x <= 1200)
            {
                UserProfiles.pictureBox2.Image = Properties.Resources.Plat;
                UserProfiles.label1.Text = "Platinum";
            }
            else if (x >= 1200 && x <= 5000)
            {
                UserProfiles.pictureBox2.Image = Properties.Resources.diamond;
                UserProfiles.label1.Text = "Diamond";
            }


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
            switch(user)
            {
                case "user1":
                    T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    T.pictureBox1.Tag = "user1";                   
                    currentlevel = File.ReadAllText("levelfile.txt");
                    int x = Int32.Parse(currentlevel);
                   
                    SwitchStatementIntroduction(x);
                    LevelChecking.CompleteIntroductionSection(x);
                    break;

                case "user2":
                    //The picture box of current instance is set to image of current user 
                    T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    T.pictureBox1.Tag = "user2";

                    // Data from text file (users level) is parsed into int and stored within variable  
                    currentlevel = File.ReadAllText("user2level.txt");
                    int i = Int32.Parse(currentlevel);

                    //Saving and Loading Function 
                    //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                    SwitchStatementIntroduction(i);
                    LevelChecking.CompleteIntroductionSection(i);
                    break;

                case "user3":                   
                    T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    T.pictureBox1.Tag = "user3";
                    
                    currentlevel = File.ReadAllText("user3level.txt");
                    int j = Int32.Parse(currentlevel);
                   
                    SwitchStatementIntroduction(j);
                    LevelChecking.CompleteIntroductionSection(j);
                    break;

                case "user4":                   
                    T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    T.pictureBox1.Tag = "user4";
                 
                    currentlevel = File.ReadAllText("user4level.txt");
                    int k = Int32.Parse(currentlevel);

                    SwitchStatementIntroduction(k);
                    LevelChecking.CompleteIntroductionSection(k);
                    break;
            }
          
        }

        #endregion

        #region Program Flow

        private void PF_btn_Click(object sender, EventArgs e)
        {
           
            switch (user)
            {            
                case "user1":
                    //The picture box of current instance is set to image of user 
                    PF.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    PF.pictureBox1.Tag = "user1";
                    // Data from text file (users level) is parsed into int and stored within variable  
                    currentlevel = File.ReadAllText("levelfile.txt");
                    int user1level = Int32.Parse(currentlevel);
                    SwitchStatementPF(user1level);
                    LevelChecking.CompletePF(user1level);
                    break;

                case "user2":
                    //The picture box of current instance is set to image of current user 
                    PF.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    PF.pictureBox1.Tag = "user2";
                    // Data from text file (users level) is parsed into int and stored within variable  
                    currentlevel = File.ReadAllText("user2level.txt");
                    int user2level = Int32.Parse(currentlevel);
                    SwitchStatementPF(user2level);
                    LevelChecking.CompletePF(user2level);
                    break;

                case "user3":
                    //The picture box of current instance is set to image of current user 
                    PF.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    PF.pictureBox1.Tag = "user3";
                    // Data from text file (users level) is parsed into int and stored within variable  
                    currentlevel = File.ReadAllText("user3level.txt");
                    int user3level = Int32.Parse(currentlevel);
                    SwitchStatementPF(user3level);
                    LevelChecking.CompletePF(user3level);
                    break;

                case "user4":
                    //The picture box of current instance is set to image of current user 
                    PF.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    PF.pictureBox1.Tag = "user4";
                    // Data from text file (users level) is parsed into int and stored within variable  
                    currentlevel = File.ReadAllText("user4level.txt");
                    int user4level = Int32.Parse(currentlevel);
                    SwitchStatementPF(user4level);
                    LevelChecking.CompletePF(user4level);
                    break;
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
            switch (user)
            {
                case "user1":
                    this.Hide();

                    currentlevel = File.ReadAllText("levelfile.txt");

                    UserProfiles.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    UserProfiles.pictureBox1.Tag = "user1";
                    UserProfiles.name_lb.Text = "User 1";
                    UserProfiles.level.Text = currentlevel;
                    UserProfiles.exp.Text = File.ReadAllText("exp1.txt");
                    int x = Int32.Parse(currentlevel);
                    string exp = File.ReadAllText("exp1.txt");
                    int y = int.Parse(exp);
                    Badges(y);
                    UserProfiles.ShowDialog();
                    this.Close();
                    break;

                case "user2":
                    this.Hide();
                    currentlevel = File.ReadAllText("user2level.txt");

                    UserProfiles.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    UserProfiles.pictureBox1.Tag = "user2";
                    UserProfiles.name_lb.Text = "User 2";
                    UserProfiles.level.Text = File.ReadAllText("user2level.txt");
                    UserProfiles.exp.Text = File.ReadAllText("exp2.txt");
                    int user2 = Int32.Parse(currentlevel);
                    Badges(user2);
                    UserProfiles.ShowDialog();
                    this.Close();
                    break;

                case "user3":
                    this.Hide();
                    currentlevel = File.ReadAllText("user3level.txt");

                    UserProfiles.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    UserProfiles.pictureBox1.Tag = "user3";
                    UserProfiles.name_lb.Text = "User 3";
                    UserProfiles.level.Text = File.ReadAllText("user3level.txt");
                    UserProfiles.exp.Text = File.ReadAllText("exp3.txt");
                    int user3 = Int32.Parse(currentlevel);
                    Badges(user3);
                    UserProfiles.ShowDialog();
                    this.Close();
                    break;

                case "user4":
                    this.Hide();
                    currentlevel = File.ReadAllText("user4level.txt");

                    UserProfiles.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    UserProfiles.pictureBox1.Tag = "user4";
                    UserProfiles.name_lb.Text = "User 4";
                    UserProfiles.level.Text = File.ReadAllText("user4level.txt");
                    UserProfiles.exp.Text = File.ReadAllText("exp4.txt");
                    int user4 = Int32.Parse(currentlevel);
                    Badges(user4);
                    UserProfiles.ShowDialog();
                    this.Close();
                    break;
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
            switch (user)
            {
                case "user1":
                    S.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    S.pictureBox1.Tag = "user1";
                    currentlevel = File.ReadAllText("levelfile.txt");
                    int x = Int32.Parse(currentlevel);
                    LevelChecking.CompleteSimpleDataSection(x);
                    SwitchStatementSimple(x);
                    break;

                case "user2":
                    S.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    S.pictureBox1.Tag = "user2";
                    currentlevel = File.ReadAllText("user2level.txt");
                    int user2 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteSimpleDataSection(user2);
                    SwitchStatementSimple(user2);
                    break;

                case "user3":
                    S.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    S.pictureBox1.Tag = "user3";
                    currentlevel = File.ReadAllText("user3level.txt");
                    int user3 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteSimpleDataSection(user3);
                    SwitchStatementSimple(user3);
                    break;

                case "user4":
                    S.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    S.pictureBox1.Tag = "user4";
                    currentlevel = File.ReadAllText("user4level.txt");
                    int user4 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteSimpleDataSection(user4);
                    SwitchStatementSimple(user4);
                    break;
            }       
        }

        #endregion

        #region End Game Button 
        private void Button1_Click(object sender, EventArgs e)
        {
            switch (user)
            {
                case "user1":
                    E.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    E.pictureBox1.Tag = "user1";

                    currentlevel = File.ReadAllText("levelfile.txt");
                    int x = Int32.Parse(currentlevel);

                    LevelChecking.CompleteEnd(x);
                    SwitchEndGame(x);
                    break;

                case "user2":
                    E.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    E.pictureBox1.Tag = "user2";

                    currentlevel = File.ReadAllText("user2level.txt");
                    int user2 = Int32.Parse(currentlevel);

                    SwitchEndGame(user2);
                    LevelChecking.CompleteEnd(user2);
                    break;

                case "user3":
                    E.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    E.pictureBox1.Tag = "user3";

                    currentlevel = File.ReadAllText("user3level.txt");
                    int user3 = Int32.Parse(currentlevel);

                    SwitchEndGame(user3);
                    LevelChecking.CompleteEnd(user3);
                    break;

                case "user4":
                    E.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    E.pictureBox1.Tag = "user4";

                    currentlevel = File.ReadAllText("user4level.txt");
                    int user4 = Int32.Parse(currentlevel);

                    SwitchEndGame(user4);
                    LevelChecking.CompleteEnd(user4);
                    break;
            }           
        }

        #endregion

        private void Ach_button(object sender, EventArgs e)
        {
            switch (user)
            {
                case "user1":
                    this.Hide();
                    Ach.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    Ach.pictureBox1.Tag = "user1";
                    currentlevel = File.ReadAllText("levelfile.txt");
                    int x = Int32.Parse(currentlevel);
                    Achievements(x);

                    Ach.ShowDialog();
                    this.Close();
                    break;

                case "user2":
                    this.Hide();
                    Ach.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    Ach.pictureBox1.Tag = "user2";
                    currentlevel = File.ReadAllText("user2level.txt");
                    int user2 = Int32.Parse(currentlevel);
                    Achievements(user2);

                    Ach.ShowDialog();
                    this.Close();
                    break;

                case "user3":
                    this.Hide();
                    Ach.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    Ach.pictureBox1.Tag = "user3";
                    currentlevel = File.ReadAllText("user3level.txt");
                    int user3 = Int32.Parse(currentlevel);
                    Achievements(user3);

                    Ach.ShowDialog();
                    this.Close();
                    break;

                case "user4":
                    this.Hide();
                    Ach.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    Ach.pictureBox1.Tag = "user4";
                    currentlevel = File.ReadAllText("user4level.txt");
                    int user4 = Int32.Parse(currentlevel);
                    Achievements(user4);

                    Ach.ShowDialog();
                    this.Close();
                    break;
            }           
        }

        private void SimpleDataPart2_btn(object sender, EventArgs e)
        {
            switch (user)
            {
                case "user1":
                    //The picture box of current instance is set to image of user 
                    S2.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    S2.pictureBox1.Tag = "user1";
                    // Data from text file (users level) is parsed into int and stored within variable  
                    currentlevel = File.ReadAllText("levelfile.txt");
                    int x = Int32.Parse(currentlevel);
                    LevelChecking.CompleteSimpleDataSectionPart2(x);
                    //Saving and Loading Function 
                    //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level
                    SwitchStatementSimplePart2(x);
                    break;

                case "user2":
                    S2.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    S2.pictureBox1.Tag = "user2";
                    currentlevel = File.ReadAllText("user2level.txt");
                    int user2 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteSimpleDataSectionPart2(user2);
                    SwitchStatementSimplePart2(user2);
                    break;

                case "user3":
                    S2.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    S2.pictureBox1.Tag = "user3";
                    currentlevel = File.ReadAllText("user3level.txt");
                    int user3 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteSimpleDataSectionPart2(user3);
                    SwitchStatementSimplePart2(user3);
                    break;

                case "user4":
                    S2.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    S2.pictureBox1.Tag = "user4";
                    currentlevel = File.ReadAllText("user4level.txt");
                    int user4 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteSimpleDataSectionPart2(user4);
                    SwitchStatementSimplePart2(user4);
                    break;
            }         
        }

        private void ID_button(object sender, EventArgs e)
        {
            switch (user)
            {
                case "user1":
                    //The picture box of current instance is set to image of user 
                    I.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    I.pictureBox1.Tag = "user1";
                    // Data from text file (users level) is parsed into int and stored within variable  
                    currentlevel = File.ReadAllText("levelfile.txt");
                    int x = Int32.Parse(currentlevel);
                    LevelChecking.CompleteID(x);
                    SwitchStatementID(x);
                    //Saving and Loading Function 
                    //When user compeltes questions a level is stored, the if statements are used to change what form is loaded for the user depending on level  
                    break;

                case "user2":
                    I.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    I.pictureBox1.Tag = "user2";
                    currentlevel = File.ReadAllText("user2level.txt");
                    int user2 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteID(user2);
                    SwitchStatementID(user2);
                    break;

                case "user3":
                    I.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    I.pictureBox1.Tag = "user3";
                    currentlevel = File.ReadAllText("user3level.txt");
                    int user3 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteID(user3);
                    SwitchStatementID(user3);
                    break;

                case "user4":
                    I.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    I.pictureBox1.Tag = "user4";
                    currentlevel = File.ReadAllText("user4level.txt");
                    int user4 = Int32.Parse(currentlevel);
                    LevelChecking.CompleteID(user4);
                    SwitchStatementID(user4);
                    break;
            }          
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void Introduction_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            switch (user)
            {
                case "user1":
                    In.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                    In.pictureBox1.Tag = "user1";

                    currentlevel = File.ReadAllText("levelfile.txt");
                    int x = Int32.Parse(currentlevel);

                    SwitchInt(x);
                    break;

                case "user2":
                    In.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                    In.pictureBox1.Tag = "user2";

                    currentlevel = File.ReadAllText("user2level.txt");
                    int user2 = Int32.Parse(currentlevel);
                    SwitchInt(user2);
                    break;

                case "user3":
                    In.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                    In.pictureBox1.Tag = "user3";

                    currentlevel = File.ReadAllText("user3level.txt");
                    int user3 = Int32.Parse(currentlevel);

                    SwitchInt(user3);
                    break;

                case "user4":
                    In.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                    In.pictureBox1.Tag = "user4";

                    currentlevel = File.ReadAllText("user4level.txt");
                    int user4 = Int32.Parse(currentlevel);

                    SwitchInt(user4);
                    break;
            }       
        }

        private void Button10_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }
    }
}
