using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    public class UC1
    {
        public void Attendance()
        {
            Random random = new Random();
            int emp_check = random.Next(2);
            if (emp_check == 1)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }

        }
    }

}
