using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring_Project
{
    public class User
    {
        string experience;
        string level;
        string question; 

    public static User LoadCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');
            User user1 = new User();
            user1.experience = (data[0]);
            user1.level = (data[1]);
            user1.question = (data[2]);
            return user1;
        }

    }
}
