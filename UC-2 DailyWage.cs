using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagePROBLEMs
{
    internal class DailyWage
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            int hourlyWageRate = 10; // Assuming an hourly wage rate of $10
            int hoursWorked = 8; // Assuming the employee worked 8 hours

            int dailyWage = hourlyWageRate * hoursWorked;
            Console.WriteLine($"Employee's daily wage is: ${dailyWage}");

            Console.ReadLine();
        }
    }
}
