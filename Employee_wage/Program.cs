using System;

namespace Employee_wage
{
    class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int wagePerHour = 20;
        static void Main(string[] args)
        {
            //Initialising Variables
            int empHours = 0;
            int empWage = 0;
            Random random = new Random();
            int empAttn = random.Next(0, 3);
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
            int empCheck = random.Next(0, 3);
            if (empCheck == isFullTime)
            {
                empHours = 8;
            }
            else if (empCheck == isPartTime)
            {
                empHours = 4;
            }
            else
            {
                empHours = 0;
            }
            empWage = empHours * wagePerHour;
            Console.WriteLine("Employee Wage is :" + empWage);

            /*.................................................................
             * solving wage using switch case statement
             * .........................................................*/
            switch(empCheck)
            {
                case isFullTime:
                    empHours = 8;
                    break;
                case isPartTime:
                    empHours = 4;
                    break;
                default:
                    empHours = 0;
                    break;
            }
            empWage = empHours * wagePerHour;
            Console.WriteLine("Employee Wage is :" + empWage);
        }
    }
}
