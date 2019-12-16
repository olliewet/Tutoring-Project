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
    public partial class HomePage : Form
    {
        public HomePage()
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
            //Button for navigating to Monthly page
            this.Hide();
            //Hides the form
            Topics T = new Topics();
            //Creates a new instance of the student loan form 
            T.ShowDialog();
            //Shows the form of the newly created student loan form
            this.Close();
            //closes current form
        }
    }
}
