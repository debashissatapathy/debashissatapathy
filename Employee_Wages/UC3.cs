using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    class UC3
    {
        public void partTime()
        {
            Console.WriteLine("Job Type :");
            string empType = Console.ReadLine();
            int empRateperHr = 20;
            int fullDayHr = 8;
            int partTimeHr = fullDayHr / 2;
            int salary = (partTimeHr * empRateperHr);
            switch(empType)
            {
                case "PartTime":
                    Console.WriteLine("PartTime Employee");
                    Console.WriteLine(salary);
                    break;
                case "FullTime":           
                    Console.WriteLine("FullTime EMployee");
                    Console.WriteLine(fullDayHr * empRateperHr);
                    break;

            }

        }
    }
}

