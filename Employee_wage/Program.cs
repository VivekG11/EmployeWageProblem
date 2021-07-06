using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_wage
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmpWageBuilder accenture = new EmpWageBuilder("Accenture", 50, 22, 130);
            EmpWageBuilder cognizant = new EmpWageBuilder("Cognizant", 40, 24, 130);
            accenture.ComputeWage();
            accenture.CompanyWiseWage();
            cognizant.ComputeWage();
            cognizant.CompanyWiseWage();
        }
    }
    
}
