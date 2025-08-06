using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Set
    {
        public static void SetDemo(IEnumerable<Student> studentList)
        {
            // Union: Combine two collections, removing duplicates
            var studentsWithHighGPA = studentList.Where(s => s.GPA >= 2.8m);
            var studentsWithLowGPA = studentList.Where(s => s.GPA < 3m);
            var allStudents = studentsWithHighGPA.Union(studentsWithLowGPA);
            Console.WriteLine("All Students (Union):");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - GPA: {student.GPA}");
            }

            Console.WriteLine("\n");

            // Intersect: Get common elements between two collections
            var commonStudents = studentsWithHighGPA.Intersect(studentsWithLowGPA);
            Console.WriteLine("\nCommon Students (Intersect):");
            foreach (var student in commonStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - GPA: {student.GPA}");
            }

            Console.WriteLine("\n");

            // Except: Get elements from one collection that are not in another
            var uniqueHighGPAStudents = studentsWithHighGPA.Except(studentsWithLowGPA);
            Console.WriteLine("\nUnique High GPA Students (Except):");
            foreach (var student in uniqueHighGPAStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} - GPA: {student.GPA}");
            }
        }
    }
}
