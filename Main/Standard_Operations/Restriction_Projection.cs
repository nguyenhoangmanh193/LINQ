using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Restriction_Projection
    {

        // Select and Where Operators 
        public static void GetGPAGood(IEnumerable<Student> studentList)
        {
            //// Method Syntax
            //  Deferred Execution
            var results = studentList
                .Where(s => s.GPA >= 3.0m)
                .Select(s => new
                {
                    FullName = s.FirstName + " " + s.LastName,
                    GPA = s.GPA                   
                })
                .OrderBy(s => s.GPA);

            Console.WriteLine("[Method Syntax] Students with GPA >= 3.0:");
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FullName,-20} {item.GPA,10}");
            }

            // Immediate Execution
            var r = studentList
               .Where(s => s.GPA >= 3.0m)
               .Select(s => new
               {
                   FullName = s.FirstName + " " + s.LastName,
                   GPA = s.GPA,
               })
               .OrderByDescending(s => s.GPA).ToList();


            //// Query Syntax
            var results1 = from student in studentList
                           where student.GPA >= 3.0m
                           orderby student.GPA descending
                           select new
                           {
                               Fullname = student.FirstName + " " + student.LastName,
                               GPA = student.GPA,
                           }
                           ;

            //Console.WriteLine("\n\n[Query Syntax] Students with GPA >= 3.0:");
            //foreach (var item in results1)
            //{
            //    Console.WriteLine($"{item.Fullname,-20} {item.GPA,10}");
            //}
        }


    }
}
