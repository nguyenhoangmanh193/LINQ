using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Quantifier
    {
        public static void QuantifierDemo(IEnumerable<Data.Student> studentList, IEnumerable<Data.Course> courseList, IEnumerable<Data.Enrollment> enrollmentList)
        {

            //// All enrolled students take CS101.
            // Method Syntax
            bool allStudentsEnrollCS101 = studentList
                .Where(s => enrollmentList.Any(e => e.StudentId == s.Id)) // Filter enrolled students
                .All(s => enrollmentList
                      .Where(e => e.StudentId == s.Id)
                      .All(e => e.CourseId == 101));

            Console.WriteLine($"All students enrolled in CS101: {allStudentsEnrollCS101}");

            Console.WriteLine("\n\n");

            // Query Syntax
            bool allStudentsEnrollCS101Query = (from student in studentList
                                                where enrollmentList.Any(e => e.StudentId == student.Id)
                                                select student)
                .All(s => (from e in enrollmentList
                            where e.StudentId == s.Id
                            select e.CourseId).All(c => c == 101));


            //// Are there any students taking Calculus II?

            // Method Syntax
            bool anyStudentsEnrollCalculusI = studentList
                .Any(s => enrollmentList.Any(e => e.StudentId == s.Id && e.CourseId == 2));
            Console.WriteLine($"Any students enrolled in Calculus II: {anyStudentsEnrollCalculusI}");
            if ( anyStudentsEnrollCalculusI)
            {
                var studentsInCalculusI = studentList
                    .Where(s => enrollmentList.Any(e => e.StudentId == s.Id && e.CourseId == 2))
                    .Select(s => $"{s.FirstName} {s.LastName}");
                Console.WriteLine("Students enrolled in Calculus I:");
                foreach (var student in studentsInCalculusI)
                {
                    Console.WriteLine("   - "+ student);
                }
            }

            Console.WriteLine("\n\n");

            // Query Syntax
            bool anyStudentsEnrollCalculusIQuery = (from student in studentList
                                                    where enrollmentList.Any(e => e.StudentId == student.Id && e.CourseId == 2)
                                                    select student).Any();


            //// Find which students are on the enrollment list

            // Method Syntax
            var studentsEnrolled = studentList
              .Where(s => !enrollmentList.Select(e => e.StudentId).Distinct().Contains(s.Id))
              .Select(s => $"{s.FirstName} {s.LastName}");

            Console.WriteLine("Enrolled students:");
            foreach (var name in studentsEnrolled)
            {
                Console.WriteLine($"  - {name}");
            }

            // Query Syntax
            var studentsEnrolledQuery = from student in studentList
                                        where !enrollmentList.Select(e => e.StudentId).Distinct().Contains(student.Id)
                                        select $"{student.FirstName} {student.LastName}";



        }
    }
}
