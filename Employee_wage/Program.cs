using System;

namespace Employee_wage
{
    class Program
    {
        static void Main(string[] args)
        {
            int isPresent = 1;
            int isAbsent = 0;
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
        }
    }
}
