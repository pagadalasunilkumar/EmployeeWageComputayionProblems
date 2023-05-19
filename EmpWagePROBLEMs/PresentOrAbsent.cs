using System;


namespace EmpWagePROBLEMs
{
    internal class PresentOrAbsent
    {
         public static void Main()
        {

            Console.WriteLine("Welcome to Employee Wage Computation Program");

            // Generate a random number between 0 and 1
            Random random = new Random();
            int attendance = random.Next(0, 2); // 0 represents absent, 1 represents present

            if (attendance == 1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

            Console.ReadLine();
        }
    }
}
