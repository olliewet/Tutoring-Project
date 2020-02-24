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
    public partial class Identifiers : Form
    {
        public Identifiers()
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

        private void ChangeUser()
        {
            if ((string)this.pictureBox1.Tag == "user1")
            {
                this.Hide();
                Topics T = new Topics();
                T.pictureBox1.Image = Properties.Resources.user_male_white_red_brown;
                T.pictureBox1.Tag = "user1";
                T.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user2")
            {
                this.Hide();
                Topics T = new Topics();
                T.pictureBox1.Image = Properties.Resources.user_male_olive_green;
                T.pictureBox1.Tag = "user2";
                T.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user3")
            {
                this.Hide();
                Topics T = new Topics();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_rbla;
                T.pictureBox1.Tag = "user3";
                T.ShowDialog();
                this.Close();
            }
            else if ((string)this.pictureBox1.Tag == "user4")
            {
                this.Hide();
                Topics T = new Topics();
                T.pictureBox1.Image = Properties.Resources.user_female_olive_orange;
                T.pictureBox1.Tag = "user4";
                T.ShowDialog();
                this.Close();
            }
        }
        private void Topics_btn_Click(object sender, EventArgs e)
        {
            ChangeUser();
        }

        private void ShowCode_btn(object sender, EventArgs e)
        {
            MessageBox.Show("int fred; float jim;  chat 29yesitsme;  Tip look at what the variable starts with! ");
        }

        private void Con_btn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An expression is something which can be evaluated to produce a result. We can then use the result as we like in our program. Expressions can be as simple as a single value and as complex as a large calculation. They are made up of two things, operators and operands.");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operands are things the operators work on. They are usually literal values or the identifiers of variables. In the program above first, second, third are identifiers and 2 is a literal value. A literal value is something which is literally there in the code. A literal value has a type associated with it by the compiler.");
        }


        private void Button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here are a few example expressions: " + System.Environment.NewLine + 
                "2 + 3 * 4" + System.Environment.NewLine +
                "-1 + 3" + System.Environment.NewLine + 
                "(2 + 3) * 4");
        }

        private void Button3_Click(object sender, EventArgs e)
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

        

        private void Tb_a1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabPage6_Click(object sender, EventArgs e)
        {

        }
    }
}
