using System;
using System.Collections;
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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
        }

        #region variables
        private int id;
        private int points = 0;
        private int count = 0;
        private string category = "Test";
        int Count2 = 0;
        List<int> randomNumbers = new List<int>();
        Random rand = new Random();
        #endregion


        private void Topics_btn_Click(object sender, EventArgs e)
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
      
      
        
        private void Button1_Click(object sender, EventArgs e)
        {
            int num = 1;
            
            ArrayList list = new ArrayList();
            Question q = new Question();
            button1.Enabled = false;
            id = rand.Next(1, 11);
            randomNumbers.Add(id);
            list = q.getQuestion(id, category);

            if (list.Count > 1)
            {
                label24.Text = list[0].ToString();
                foreach (Control control in options.Controls)
                {
                    RadioButton radio = control as RadioButton;
                    radio.Enabled = true;
                    radio.Text = list[num].ToString();
                    num++;
                }
            }
            
        }

        private void EndGame_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            options.Enabled = false;
            Submit.Enabled = false;
            Next.Enabled = true;


            string result = "NO SELECTION";
            result res = new result();

            foreach (Control control in options.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio.Checked)
                {
                    result = res.getResult(radio.Text, id, category);
                }
            }

            if (result == "CORRECT" && ((string)this.pictureBox1.Tag == "user1"))
            {
                points = points + 10;
                pointsvalue.Text = points.ToString();
                pointsvalue.ForeColor = Color.Green;
                explain.Visible = true;
                explain.Text = "Congratulations!! You have selected the correct option.";
                explain.ForeColor = Color.Green;
                User.Exp();
            }
            else if (result == "CORRECT" && ((string)this.pictureBox1.Tag == "user2"))
            {
                points = points + 10;
                pointsvalue.Text = points.ToString();
                pointsvalue.ForeColor = Color.Green;
                explain.Visible = true;
                explain.Text = "Congratulations!! You have selected the correct option.";
                explain.ForeColor = Color.Green;
                User.Exp2();
            }
            else if (result == "CORRECT" && ((string)this.pictureBox1.Tag == "user3"))
            {
                points = points + 10;
                pointsvalue.Text = points.ToString();
                pointsvalue.ForeColor = Color.Green;
                explain.Visible = true;
                explain.Text = "Congratulations!! You have selected the correct option.";
                explain.ForeColor = Color.Green;
                User.Exp3();
            }
            else if (result == "CORRECT" && ((string)this.pictureBox1.Tag == "user4"))
            {
                points = points + 10;
                pointsvalue.Text = points.ToString();
                pointsvalue.ForeColor = Color.Green;
                explain.Visible = true;
                explain.Text = "Congratulations!! You have selected the correct option.";
                explain.ForeColor = Color.Green;
                User.Exp4();
            }
            else if (result == "WRONG" || result == "NO SELECTION")
            {
                Count2++;
                if (Count2 > 5)
                {
                    //Close Form if failed to complete
                }
                pointsvalue.Text = points.ToString();
                pointsvalue.ForeColor = Color.Red;
                explain.Visible = true;
                explain.Text = "oops!! You have selected the wrong option.";
                explain.ForeColor = Color.Red;
            }
            else
            {
                             
                Submit.Enabled = false;
                Next.Enabled = false;
                
            }

        }

        private void Next_Click(object sender, EventArgs e)
        {
            int num = 1;
            explain.Visible = false;

            foreach (Control control in options.Controls)
            {
                RadioButton radio = control as RadioButton;
                radio.Checked = false;
            }

            Next.Enabled = false;
            Submit.Enabled = true;
            options.Enabled = true;
            options.Refresh();

            do id = rand.Next(1, 11);
            while (randomNumbers.Contains(id));
            randomNumbers.Add(id);

            Question q = new Question();
            ArrayList list = new ArrayList();
            list = q.getQuestion(id, category);

            if (list.Count > 5)
            {
                if (count < 5)
                {
                    label24.Text = list[0].ToString();
                    foreach (Control control in options.Controls)
                    {
                        RadioButton radio = control as RadioButton;
                        radio.Enabled = true;
                        radio.Text = list[num].ToString();
                        num++;
                    }
                    count++;
                }

                else if (count > 5)
                {
                    MessageBox.Show("You have successfully completed the quiz and scored " + points + " points");
                    Submit.Enabled = false;
                    foreach (Control control in options.Controls)
                    {
                        RadioButton radio = control as RadioButton;
                        radio.Enabled = false;
                    }

                }
            }
            else
            {
                Submit.Enabled = false;
                Next.Enabled = false;
            }
        }
    }
}
