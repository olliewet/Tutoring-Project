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
    public partial class UserPage : Form
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to exit?";
            const string caption = "";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void User1_Click(object sender, EventArgs e)
        {
           
            this.Hide();       
            Topics T = new Topics();
            T.ShowDialog();          
            this.Close();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
