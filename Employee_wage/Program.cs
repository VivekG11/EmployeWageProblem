using System;

namespace Employee_wage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialising Variables
            int isPresent = 1;
            int isAbsent = 0;
            int isFullTime = 1;
            int wagePerHour = 20;
            int empHours = 0;
            int empWage = 0;
            Random random = new Random();
            int empAttn = random.Next(0, 2);
            if (empAttn == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            /*...................................................................
             * Calculating employee wage based on working hours*/
            int empCheck = random.Next(0, 2);
            if (empCheck == isFullTime)
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }
            empWage = empHours * wagePerHour;
            Console.WriteLine("Employee Wage is :" + empWage);
        }
    }
}
