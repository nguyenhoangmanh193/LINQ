using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Conversion
    {
        public static void ConversionDemo(
           IEnumerable<Student> studentList,
           IEnumerable<Course> courseList,
           IEnumerable<Enrollment> enrollmentList)
        {
            //  Get list of students enrolled in courses
            var enrolledStudents = studentList
                .Where(s => s.IsEnrolled)
                .ToList(); //  List<Student>

            Console.WriteLine("Type ToList: " + enrolledStudents.GetType().Name);

            Console.WriteLine("\n\n");

            // Convert to an array of students
            var enrolledStudentss = studentList
                .Where(s => s.IsEnrolled)
                .ToArray(); //  T[]
            Console.WriteLine("Type ToArray: " + enrolledStudentss.GetType().Name);

            Console.WriteLine("\n\n");

            // ToDictionary
            var studentDictionary = studentList
                .Where(s => s.IsEnrolled)
                .ToDictionary(s => s.Id, s => s); //  Dictionary<int, Student>
            Console.WriteLine("ToDictionary: " + studentDictionary.GetType().Name);
            Console.WriteLine("Enrolled Students Dictionary:");
            foreach (var student in studentDictionary)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value.FirstName} {student.Value.LastName}");
            }
        }
    }
}
