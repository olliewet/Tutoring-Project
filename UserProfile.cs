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
        private List<User> _userList;

        public List<User> userList
        {
            get
            {
                return _userList;
            }
            set
            {
                _userList = value;
                for (int i = 0; i < value.Count; i++)
                {
                    user_lb.Items.Add(value.ElementAt(i));

                }               
            }
        }

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
    }
}
