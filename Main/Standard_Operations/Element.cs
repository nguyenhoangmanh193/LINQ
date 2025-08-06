using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Element
    {
        public static void ElementDemo(IEnumerable<Student> studentList, IEnumerable<Course> courseList, IEnumerable<Enrollment> enrollmentList)
        {
            //  Get student in 2st place
            var studentAt2 = studentList.ElementAt(1);
            Console.WriteLine($"Student at 2nd place: {studentAt2.FirstName} {studentAt2.LastName}");
            // Get student in non-existent index
            var studentAt100 = studentList.ElementAtOrDefault(100);
            Console.WriteLine($"Student at 100nd place: {(studentAt100 == null ? "null" : studentAt100.FirstName)}");

            Console.WriteLine("\n\n");

            // Take the first student
            var firstStudent = studentList.First();
            Console.WriteLine($"First student: {firstStudent.FirstName} {firstStudent.LastName}");
            // Take the first student with GPA > 4.0
            var firstStudentWithGPA = studentList.FirstOrDefault(s => s.GPA > 4.0m);
            Console.WriteLine($"First student with GPA > 4.0: {(firstStudentWithGPA == null ? "null" : firstStudentWithGPA.FirstName + " " + firstStudentWithGPA.LastName)}");

            Console.WriteLine("\n\n");

            // Take the last student
            var lastStudent = studentList.Last();
            Console.WriteLine($"Last student: {lastStudent.FirstName} {lastStudent.LastName}");
            // Take the last student with GPA > 4.0
            var lastStudentWithGPA = studentList.LastOrDefault(s => s.GPA > 4.0m);
            Console.WriteLine($"Last student with GPA > 4.0: {(lastStudentWithGPA == null ? "null" : lastStudentWithGPA.FirstName + " " + lastStudentWithGPA.LastName)}");

            Console.WriteLine("\n\n");

            // Get student with Id = 2, there is only one such student
            var studentWithId2 = studentList.Single(s => s.Id == 2);
            Console.WriteLine($"Student with Id = 2: {studentWithId2.FirstName} {studentWithId2.LastName}");
            // Get student with Id = 100, there is no such student
            var studentWithId100 = studentList.SingleOrDefault(s => s.Id == 100);
            Console.WriteLine($"Student with Id = 100: {(studentWithId100 == null ? "null" : studentWithId100.FirstName + " " + studentWithId100.LastName)}");


        }
    }
}
