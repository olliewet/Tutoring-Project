using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring_Project
{
    class LevelChecking
    {
        public static void CompleteIntroductionSection(int x)
        {
            if (x > 4)
            {
                MessageBox.Show("Completed Section");
            }
        }

        public static void CompleteSimpleDataSection(int x)
        {
            if (x < 4)
            {
                MessageBox.Show("Complete Introduction");
            }
            else if (x > 13)
            {
                MessageBox.Show("Completed Section");
            }
        }

        public static void CompleteSimpleDataSectionPart2(int x)
        {
            if (x < 13)
            {
                MessageBox.Show("Complete the Previous Section");
            }
            else if (x > 15)
            {
                MessageBox.Show("Completed Section"); 
            }
        }

        public static void CompleteID(int x)
        {
            if (x < 17)
            {
                MessageBox.Show("Complete the Previous Section");
            }
            else if (x > 18)
            {
                MessageBox.Show("Completed Section");
            }
        }

        public static void CompletePF(int x)
        {
            if (x < 19)
            {
                MessageBox.Show("Complete the Previous Section");
            }
            else if (x >= 25) // Update Number at some point
            {
                MessageBox.Show("Completed Section");
            }
        }

        public static void CompleteEnd(int x)
        {
            if (x < 25)
            {
                MessageBox.Show("Complete the Previous Section");
            }
            
        }

    }
}
