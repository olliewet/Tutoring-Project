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
    public partial class introduction : Form
    {
        public introduction()
        {
            InitializeComponent();
        }

        private void Topics_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userpage T = new Userpage();
            T.ShowDialog();
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

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void Back_btn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }
    }
}
