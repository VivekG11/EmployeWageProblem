using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_wage
{
    class CompanyEmpWage
    {
        public string companyName;
        public int wagePerHour;
        public int numOfWorkingDays;
        public int maxWorkingHours;
        public int totalEmpWage;

        public CompanyEmpWage(String companyName, int wagePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            this.companyName = companyName;
            this.wagePerHour = wagePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public void CompanyWage()
        {
            Console.WriteLine("Total Employee wage of "+this.companyName + " is :"+this.totalEmpWage);
            Console.WriteLine("\n");
        }
    }
}
