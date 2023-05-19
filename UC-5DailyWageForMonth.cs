using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagePROBLEMs
{
    internal class UC_5DailyWageForMonth
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
            Console.WriteLine("Enter employee type (1: Part-time):");
            int employeeType = Convert.ToInt32(Console.ReadLine());

            switch (employeeType)
            {
                case 1:
                    AddPartTimeEmployee();
                    break;
                default:
                    Console.WriteLine("Invalid employee type.");
                    break;
            }
        }

        static void AddPartTimeEmployee()
        {
            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            // Assuming part-time hourly wage is $10
            int hourlyWage = 10;
            int hoursWorkedPerDay = 8;
            int workingDaysPerMonth = 20;

            int totalHoursWorked = hoursWorkedPerDay * workingDaysPerMonth;
            int wage = hourlyWage * totalHoursWorked;

            Console.WriteLine($"Part-time employee {name} added. Wage for the month: ${wage}");
        }
    }

}

