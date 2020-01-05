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
    public partial class UserProfile : Form
    {
        
    public UserProfile()
        {
            InitializeComponent();
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

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void User_lb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Topics_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userpage T = new Userpage();
            T.ShowDialog();
            this.Close();
        }

        private void Level_Click(object sender, EventArgs e)
        {

        }
    }
}
