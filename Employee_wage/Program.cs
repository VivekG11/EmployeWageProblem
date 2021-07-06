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
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Trends", 25, 9, 14);
            empWageBuilder.addCompanyEmpWage("KFC", 20, 8, 15);
            empWageBuilder.ComputeEmpWage();
        }
    }
    
}
