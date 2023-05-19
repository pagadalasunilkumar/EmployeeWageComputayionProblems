using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWagePROBLEMs
{
    internal class TotalWorkingHours
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
            int totalWorkingHours = 100;
            int totalWage = 0;
            int totalHoursWorked = 0;
            int totalDaysWorked = 0;

            while (totalHoursWorked < totalWorkingHours && totalDaysWorked < workingDaysPerMonth)
            {
                totalHoursWorked += hoursWorkedPerDay;
                totalDaysWorked++;
                totalWage += (hourlyWage * hoursWorkedPerDay);
            }

            Console.WriteLine($"Part-time employee {name} added.");
            Console.WriteLine($"Total days worked: {totalDaysWorked}");
            Console.WriteLine($"Total hours worked: {totalHoursWorked}");
            Console.WriteLine($"Total wage: ${totalWage}");
        }
    }

}

