using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages
{
    class UC5
    {
        public void Total_Time()
        {
            int empRateperHr = 20;
            int fullDayHr = 8;
            int Working_Day = 20;
            int per_on_sal_full = (empRateperHr * fullDayHr * Working_Day);
            int per_mon_sal_part = (empRateperHr * (fullDayHr / 2) * Working_Day);
            int i;
            Console.WriteLine("Job Type For Monthly salary :");
            string empType = Console.ReadLine();
            switch (empType)
            {
                case "PartTime":
                    for (i = 1; i <=( (Working_Day*5)/2); i++)
                    {
                        //Console.WriteLine("PartTime Monthly Salary");
                        Console.Write(i+",");
                    }
                    break;

                case "FullTime":
                    for (i=1; i <= Working_Day*5; i++)
                    {
                        //Console.WriteLine("FullTime Monthly Salary");
                        Console.WriteLine(i+",");
                    }
                    break;
            }
        }
    }
}
