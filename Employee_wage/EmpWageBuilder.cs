using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_wage
{ 
    public interface IEmployeWage
    {
        void addCompanyEmpWage(String companyName, int wagePerHour, int numOfWorkingDays, int maxWorkingHourse);
    }
    class EmpWageBuilderArray
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
         
        //initialising num of companies and array
        private int numOfCompany = 0;
        public CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(String companyName, int wagePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(companyName, wagePerHour, numOfWorkingDays, maxWorkingHours);
            numOfCompany++;//adding companies
        }


        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine("Total wages for each company ");
                this.companyEmpWageArray[i].CompanyWage();
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHours = 0, totWorkingHours = 0, totalWorkingDays = 0;


            
            while (totWorkingHours <= companyEmpWage.maxWorkingHours && totalWorkingDays < companyEmpWage.numOfWorkingDays)
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
                //Console.WriteLine("working Days :"+totalWorkingDays+" Emp Hours :"+empHours);
                
            }
            return totWorkingHours * companyEmpWage.wagePerHour;
        }
    }
}
