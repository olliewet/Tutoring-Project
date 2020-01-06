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

namespace Tutoring_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();                     
            Userpage UP = new Userpage();
            UP.ShowDialog();          
            this.Close();
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
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

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            References Ref = new References();
            Ref.ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard led = new Leaderboard();             
            led.user1.Text = File.ReadAllText("levelfile.txt");
            led.user2.Text = File.ReadAllText("user2level.txt");
            led.user3.Text = File.ReadAllText("user3level.txt");
            led.user4.Text = File.ReadAllText("user4level.txt");
            led.ShowDialog();
            this.Close();
        }
    }
}
