using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring_Project.Question_Forms
{
    public partial class Interactive_Code : Form
    {
        public Interactive_Code()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string A1 = comboBox1.SelectedItem.ToString();
            string A2 = comboBox2.SelectedItem.ToString();
            string A3 = comboBox3.SelectedItem.ToString();
            string A4 = comboBox4.SelectedItem.ToString();

                    
            if (A1.Equals("int value1 = 5; ") && A2.Equals("int value2 = 10;") && A3.Equals("int Answer = Value1 + Value2;") && A4.Equals("Console.WriteLine(Answer);"))
            {
                richTextBox1.Text = "15";
            }
            else if (A1.Equals("int value1 = 5; ") && A2.Equals("int value2 = 10;") && A3.Equals("int Answer = Value1 * Value2;") && A4.Equals("Console.WriteLine(Answer);"))
            {
                richTextBox1.Text = "50!";
            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Interactive_Code_Load(object sender, EventArgs e)
        {
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
