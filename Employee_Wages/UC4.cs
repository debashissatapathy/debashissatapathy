using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    class UC4
    {
        public static void Monthly_Sal()
        {
            int empRateperHr = 20;
            int fullDayHr = 8;
            int Working_Day = 20;
            int per_on_sal_full=(empRateperHr * fullDayHr * Working_Day);
            int per_mon_sal_part = (empRateperHr * (fullDayHr / 2) * Working_Day);
            Console.WriteLine("Job Type For Monthly salary :");
            string empType = Console.ReadLine();
            switch (empType)
            {
                case "PartTime":
                    Console.WriteLine("PartTime Monthly Salary");
                    Console.WriteLine(per_mon_sal_part);
                    break;
                case "FullTime":
                    Console.WriteLine("FullTime Monthly Salary");
                    Console.WriteLine(per_on_sal_full);
                    break;

            }
        }
    }
}
