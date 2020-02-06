using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring_Project
{
    public class User
    {
        public static void User1(int num1, int num2)
        {
            string text = File.ReadAllText("levelfile.txt");
            text = text.Replace(num1.ToString(), num2.ToString());
            File.WriteAllText("levelfile.txt", text);
        }
        public static void User2(int num1, int num2)
        {
            string text = File.ReadAllText("user2level.txt");
            text = text.Replace(num1.ToString(), num2.ToString());
            File.WriteAllText("user2level.txt", text);
        }
        public static void User3(int num1, int num2)
        {
            string text = File.ReadAllText("user3level.txt");
            text = text.Replace(num1.ToString(), num2.ToString());
            File.WriteAllText("user3level.txt", text);
        }
        public static void User4(int num1, int num2)
        {
            string text = File.ReadAllText("user4level.txt");
            text = text.Replace(num1.ToString(), num2.ToString());
            File.WriteAllText("user4level.txt", text);
        }

        public static void Exp()
        {
            try
            {
                string exp = File.ReadAllText("exp1.txt");
                int x = int.Parse(exp);
                x = x + 10;
                exp = x.ToString();
                File.WriteAllText("exp1.txt", exp);
            }
            catch
            {
                MessageBox.Show("Error With the File");
            }
        }

        public static void Exp2()
        {
            try
            {
                string exp = File.ReadAllText("exp2.txt");
                int x = int.Parse(exp);
                x = x + 10;
                exp = x.ToString();
                File.WriteAllText("exp2.txt", exp);
            }
            catch
            {
                MessageBox.Show("Error With the File");
            }
        }

        public static void Exp3()
        {
            try
            {
                string exp = File.ReadAllText("exp3.txt");
                int x = int.Parse(exp);
                x = x + 10;
                exp = x.ToString();
                File.WriteAllText("exp3.txt", exp);
            }
            catch
            {
                MessageBox.Show("Error With the File");
            }
        }

        public static void Exp4()
        {
            try
            {
                string exp = File.ReadAllText("exp4.txt");
                int x = int.Parse(exp);
                x = x + 10;
                exp = x.ToString();
                File.WriteAllText("exp4.txt", exp);
            }
            catch
            {
                MessageBox.Show("Error With the File");
            }
        }

        //Doesnt work 
        public static void Error(string message)
        {
            int counter = 0;
            counter++;
            if (counter >= 3)
            {
                MessageBox.Show(message);
            }
           
        }


      
        }
    }

