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

namespace Tutoring_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Unused Buttons 
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region User Page 
        private void Button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();                     
            Userpage UP = new Userpage();
            UP.ShowDialog();          
            this.Close();
            
        }
        #endregion


        #region Exit Button 
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

        #region reference Button 
        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            References Ref = new References();
            Ref.ShowDialog();
            this.Close();
        }
        #endregion


        #region Leaderboard Button 
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard led = new Leaderboard();             
            led.user1.Text = File.ReadAllText("levelfile.txt");
            led.user2.Text = File.ReadAllText("user2level.txt");
            led.user3.Text = File.ReadAllText("user3level.txt");
            led.user4.Text = File.ReadAllText("user4level.txt");

            led.Oexp.Text = File.ReadAllText("exp1.txt");
            led.Oexp2.Text = File.ReadAllText("exp2.txt");
            led.Oexp3.Text = File.ReadAllText("exp3.txt");
            led.Oexp4.Text = File.ReadAllText("exp4.txt");

            string exp = File.ReadAllText("exp1.txt");
            int x = int.Parse(exp);

            if (Enumerable.Range(1, 100).Contains(x))
            {
                led.exp1.Text = "0";
            }
            else if (Enumerable.Range(101, 200).Contains(x))
            {
                led.exp1.Text = "1";
            }
            else if (Enumerable.Range(201, 300).Contains(x))
            {
                led.exp1.Text = "2";
            }
            else if (Enumerable.Range(301, 400).Contains(x))
            {
                led.exp1.Text = "3";
            }

            string exp2 = File.ReadAllText("exp2.txt");
            int i = int.Parse(exp2);
            if (Enumerable.Range(1, 100).Contains(i))
            {
                led.exp2.Text = "0";
            }
            else if (Enumerable.Range(101, 200).Contains(i))
            {
                led.exp2.Text = "1";
            }
            else if (Enumerable.Range(201, 300).Contains(i))
            {
                led.exp2.Text = "2";
            }
            else if (Enumerable.Range(301, 400).Contains(i))
            {
                led.exp2.Text = "3";
            }

            string exp3 = File.ReadAllText("exp3.txt");
            int ii = int.Parse(exp3);
            if (Enumerable.Range(1, 100).Contains(ii))
            {
                led.exp3.Text = "0";
            }
            else if (Enumerable.Range(101, 200).Contains(ii))
            {
                led.exp3.Text = "1";
            }
            else if (Enumerable.Range(201, 300).Contains(ii))
            {
                led.exp3.Text = "2";
            }
            else if (Enumerable.Range(301, 400).Contains(ii))
            {
                led.exp3.Text = "3";
            }

            string exp4 = File.ReadAllText("exp4.txt");
            int h = int.Parse(exp4);
            if (Enumerable.Range(1, 100).Contains(h))
            {
                led.exp4.Text = "0";
            }
            else if (Enumerable.Range(101, 200).Contains(h))
            {
                led.exp4.Text = "1";
            }
            else if (Enumerable.Range(201, 300).Contains(h))
            {
                led.exp4.Text = "2";
            }
            else if (Enumerable.Range(301, 400).Contains(h))
            {
                led.exp4.Text = "3";
            }




            led.ShowDialog();
            this.Close();
        }

        #endregion 
    }
}
