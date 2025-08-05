using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Grouping
    {
        // Grouping Students by Enrollment Status
        public static void GroupStudentsByEnrollmentStatus(IEnumerable<Student> studentList)
        {
            // Method Syntax

            var lookup = studentList.ToLookup(s => s.IsEnrolled);
            var enrolledStudents = lookup[true]; // Quick access to enrolled student groups

            var groupedByGPA = studentList
                 .GroupBy(s => s.IsEnrolled);

            foreach (var group in groupedByGPA)
            {
                Console.WriteLine($"IsEnrolled: {group.Key}");

                foreach (var student in group)
                {
                    Console.WriteLine($"\t{student.FirstName} {student.LastName}");
                }
            }

            // Query Syntax
            var groupedByGPA1 = from student in studentList
                               group student by student.IsEnrolled into studentGroup
                               select studentGroup;

            //foreach (var group in groupedByGPA)
            //{
            //    Console.WriteLine($"IsEnrolled: {group.Key}");

            //    foreach (var student in group)
            //    {
            //        Console.WriteLine($"\t{student.FirstName} {student.LastName}");
            //    }
            //}


            // Lookup and GroupBy Comparison
            //var lookupp = studentList.ToLookup(s => s.IsEnrolled);
            //var grouped = studentList.GroupBy(s => s.IsEnrolled);

            //studentList.Add(new Student { FirstName = "New", IsEnrolled = true });

            //var lookupGroupCount = lookup[true].Count(); // Excluding new elements


            //var groupedCount = grouped.First(g => g.Key == true).Count(); // A new element

            //Console.WriteLine($"Lookup Count: {lookupGroupCount} , Group: {groupedCount}"); // 11 and 12

        }
    }
}
