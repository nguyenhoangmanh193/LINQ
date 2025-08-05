using LINQExamples_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Example1.Standard_Operations
{
    internal class Restriction_Projection
    {
        public static void ShowHighSalaryEmployees(IEnumerable<Employee> employeeList)
        {

            ////// Select and Where Operators - Method Syntax  
            var results = employeeList.Select(e => new
            {
                FullName = e.FirstName + " " + e.LastName,
                AnnualSalary = e.AnnualSalary

            }).Where(e => e.AnnualSalary >= 50000);

            foreach (var item in results)
            {
                Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            }

            //////Select and Where Operators - Query Syntax 
            var results1 = from emp in employeeList
                           where emp.AnnualSalary >= 50000
                           select new
                           {
                               FullName = emp.FirstName + " " + emp.LastName,
                               AnnualSalary = emp.AnnualSalary
                           };

            foreach (var item in results1)
            {
                Console.WriteLine($"{item.FullName,-20} {item.AnnualSalary,10}");
            }

        }


    }
}
