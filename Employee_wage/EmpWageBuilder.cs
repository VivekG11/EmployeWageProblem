using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Employee_wage
{ 
    public interface IEmployeWage
    {
        void addCompanyEmpWage(String companyName, int wagePerHour, int numOfWorkingDays, int maxWorkingHourse);
    }
    class EmpWageBuilderArray : IEmployeWage
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        //initialising num of companies and array
        // private int numOfCompany = 0;
        //public CompanyEmpWage[] companyEmpWageArray;
        //public EmpWageBuilderArray()
        //{
        //  this.companyEmpWageArray = new CompanyEmpWage[5];
        //}
        public ArrayList companyList;

        public EmpWageBuilderArray()
        {
            this.companyList = new ArrayList();
        }

        public void addCompanyEmpWage(String companyName, int wagePerHour, int numOfWorkingDays, int maxWorkingHours)
        {
            CompanyEmpWage wage= new CompanyEmpWage(companyName, wagePerHour, numOfWorkingDays, maxWorkingHours);
            this.companyList.Add(wage);
        }


        public void ComputeEmpWage()
        {
            foreach(CompanyEmpWage i in this.companyList)
            {
                i.setTotalEmpWage(this.ComputeEmpWage(i));
                i.CompanyWage();
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
                Console.WriteLine("Daily wage :"+(empHours*companyEmpWage.wagePerHour));
                totalWorkingDays++;
                totWorkingHours += empHours;
               // Console.WriteLine("Hours :"+totWorkingHours+"");
                //Console.WriteLine("working Days :"+totalWorkingDays+" Emp Hours :"+empHours);
                
            }
            return totWorkingHours * companyEmpWage.wagePerHour;
        }
    }
}
