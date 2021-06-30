using System;

namespace Employee_wage
{
    class Program
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public const int wagePerHour = 20;
        public const int numOfWorkingDays = 13;
        public const int maxWorkiingHours = 100;
        static void Main(string[] args)
        {
            //Initialising Variables
            int empHours = 0;
            int totWorkingHours = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            

            while(totWorkingHours < maxWorkiingHours && totalWorkingDays < numOfWorkingDays)
            {
               
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
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
                totalWorkingDays++;
                totWorkingHours += empHours;
            }
            Console.WriteLine("working Days :" + totalWorkingDays + " and total working hours are : " + totWorkingHours);
            totalEmpWage = totWorkingHours * wagePerHour;
            Console.WriteLine("Total wage of employee is : "+ totalEmpWage);
        }
    }
}
