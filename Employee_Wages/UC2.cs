using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    class UC2
    {
        public void salary()
        {
            int isPresent = 1;
            int empRateperHr = 20;
            int fullDayHr = 8;
            string sal = "No Salary";
            Random random = new Random();
            int emp_check = random.Next(2);
            if (emp_check == 1)
            {
                Console.WriteLine("Present");
                if(isPresent==emp_check)
                {
                    Console.WriteLine(empRateperHr * fullDayHr);
                }
            }
            else
            {
                Console.WriteLine("Absent");
                Console.WriteLine(sal);
            }

            
           
        }
    }
}
