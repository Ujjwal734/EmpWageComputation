using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class TotalWorking
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;  
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_Working_days = 2;
        public const int Max_Hrs_In_Month = 10;
        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingdays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingdays < Num_Of_Working_days)
            {
                totalWorkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0,3);
                switch(empcheck)
                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : " +totalWorkingdays + "Emp Hrs : "+ empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage : "+ totalEmpWage);
        }
    }
}
