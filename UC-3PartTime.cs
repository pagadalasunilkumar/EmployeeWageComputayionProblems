using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagePROBLEMs
{
    internal class UC_3PartTime
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int hourlyWageRate = 10; // Assuming an hourly wage rate of $10
            int fullTimeHours = 8; // Assuming the employee worked 8 hours for full-time
            int partTimeHours = 4; // Assuming the employee worked 4 hours for part-time

            int fullTimeWage = hourlyWageRate * fullTimeHours;
            int partTimeWage = hourlyWageRate * partTimeHours;

            Console.WriteLine($"Employee's full-time daily wage is: ${fullTimeWage}");
            Console.WriteLine($"Employee's part-time daily wage is: ${partTimeWage}");

            Console.ReadLine();
        }

    }
}
