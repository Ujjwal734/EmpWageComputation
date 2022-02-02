using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class Employwagecomputation
    {
        public const int Full_time = 1;
        public const int Part_time = 2;
        public const int RatePerHrs = 20;
        public const int Max_Working_Days = 20;
        public const int Max_Working_hrs = 100;
        public void empattendence()
        {
            Random rnd = new Random();
            int num = rnd.Next();
            if (num % 2 == 0)
            {
                Console.WriteLine("Employ is Present");
            }
            else
            {
                Console.WriteLine("Employ is Absent");
            }
        }
        public void Parttime()
        {
            int empwage = 0;
            int empHrs = 0;
            int totalemphrs = 0;
            int totaldays = 1;
            int totalempwage = 0;
            string typeofEmploye = "";
            string name = "xyz";
            Random employee = new Random();
            for (int day = 1; day <= Max_Working_Days; day++)
            {
                int randominput = employee.Next(0, 3);
                switch (randominput)
                {
                    case Full_time:
                        empHrs = 8;
                        typeofEmploye = "Full Time";
                        break;
                    case Part_time:
                        empHrs = 4;
                        typeofEmploye = "Part Time";
                        break;
                    default:
                        empHrs = 0;
                        typeofEmploye = "Absent";
                        break;
                }
                totalemphrs = totalemphrs + empHrs;
                totalempwage = RatePerHrs * totalemphrs;
                Console.WriteLine("{0}Employe of day: {1} wage is {2}", typeofEmploye, totaldays, empwage);
                totalempwage = totalempwage + empwage;
                totaldays++;
            }
            Console.WriteLine("Employe wage for {0} day is : {1}", Max_Working_Days, totalempwage);
            Console.ReadLine();
        }
    }

}

