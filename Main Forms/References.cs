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
    public partial class References : Form
    {
        public References()
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

        private void Con_btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void Topics_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userpage UP = new Userpage();
            UP.ShowDialog();
            this.Close();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Con_btn1_Click_1(object sender, EventArgs e)
        {           
            tabControl1.SelectTab(1);
        }
    }
}
