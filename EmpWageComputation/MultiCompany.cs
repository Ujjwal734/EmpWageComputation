using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class MultiCompany
    {
        public const int Part_Time = 1;
        public const int Full_Time = 2;
        public static int computeEmpWage(string Company, int emprateHour,int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch(empCheck)
                {
                    case Part_Time:
                        empHrs = 4;
                        break;
                    case Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day : "+ totalWorkingDays + "Emp Hrs : " + empHrs);

            }
            int totalEmpWage = totalEmpHrs * emprateHour;
            Console.WriteLine("Total Emp Wage for Company : " + Company + " is : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("Tata", 20, 2, 10);
            computeEmpWage("Apple", 10, 4, 20);
        }
    }
}
