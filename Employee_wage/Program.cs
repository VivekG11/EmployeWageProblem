using System;

namespace Employee_wage
{
    class WageBuilder
    {

        public string companyName;
        public const int isFullTime = 1;
        public const int isPartTime = 2;
        public int wagePerHour ;
        public int numOfWorkingDays;
        public int maxWorkingHours;



        public WageBuilder(String companyName , int wagePerHour, int numOfWorkingDays, int maxWorkingHours )
        {
            this.companyName = companyName;
            this. wagePerHour = wagePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void ComputeWage()
        {
            //Initialising Variables
            int empHours = 0;
            int totWorkingHours = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;


            Random random = new Random();
            while (totWorkingHours < maxWorkingHours && totalWorkingDays < numOfWorkingDays)
            {
               
                
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
        static void Main(string[] args)
        {
            WageBuilder accenture = new WageBuilder("Accenture", 50, 22, 130);
            WageBuilder cognizant = new WageBuilder("Cognizant", 40, 24, 130);
            accenture.ComputeWage();
            cognizant.ComputeWage();
        }
    }
}
