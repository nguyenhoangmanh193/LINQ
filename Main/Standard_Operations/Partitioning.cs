using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Partitioning
    {
        public static void PartitioningDemo(
            IEnumerable<Student> studentList,
           IEnumerable<Enrollment> enrollmentList)
        {
            // Get the first 2 students who have enrolled in the course
            // Take(int count)
            var enrollStudent = studentList
                .Where(s => enrollmentList.Any(e => e.StudentId == s.Id))
                .Take(2);
            Console.WriteLine("  - Take(2) enrolled students:");
            foreach (var s in enrollStudent)
                Console.WriteLine($"{s.FirstName} {s.LastName}");

            Console.WriteLine("\n\n");

            // Skip the first student enrolled
            //  Skip(int count)
            var skipFirstEnroll = studentList
                .Where(s => enrollmentList.Any(e => e.StudentId == s.Id))
                .Skip(1);
            Console.WriteLine("  - Skip(1) enrolled students:");
            foreach (var s in skipFirstEnroll)
                Console.WriteLine($"{s.FirstName} {s.LastName}");

            Console.WriteLine("\n\n");

            // Take enrolled students until you find someone with a GPA < 3.0
            // TakeWhile(Func<T, bool> predicate)
            var takeWhileEnroll = studentList
                .Where(s => enrollmentList.Any(e => e.StudentId == s.Id))
                .TakeWhile(s => s.GPA >= 3.0m);
            Console.WriteLine("TakeWhile enrolled students with GPA >= 3.0:");
            foreach (var s in takeWhileEnroll)
                Console.WriteLine($" - {s.FirstName} {s.LastName} - GPA: {s.GPA}");

            //  Skip enrolled students until you find one with a GPA < 3.0
            // SkipWhile(Func<T, bool> predicate)
            var skipWhileEnroll = studentList
                .Where(s => enrollmentList.Any(e => e.StudentId == s.Id))
                .SkipWhile(s => s.GPA >= 3.0m);
            Console.WriteLine("\nSkip enrolled students until you find one with a GPA < 3.0:");
            foreach (var s in skipWhileEnroll)
                Console.WriteLine($" - {s.FirstName} {s.LastName} - GPA: {s.GPA}");
        }
    }
}
