using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Aggregate
    {
        public static void AggregateDemo(
           IEnumerable<Student> studentList,
           IEnumerable<Course> courseList,
           IEnumerable<Enrollment> enrollmentList )
        {
            // Count – Number of students per subject
            var studentCountPerCourse = courseList.Select(course => new
                {
                    CourseTitle = course.Title,
                    StudentCount = enrollmentList.Count(e => e.CourseId == course.Id)
                });
            Console.WriteLine("Number of students per course:");
            foreach (var item in studentCountPerCourse)
            {
                Console.WriteLine($"Course: {item.CourseTitle}, Students: {item.StudentCount}");
            }

            Console.WriteLine("\n");

            // Average – Average GPA per subject
            var averageGpaPerCourse = courseList.Select(course => new
            {
                CourseTitle = course.Title,
                AverageGPA = enrollmentList
                    .Where(e => e.CourseId == course.Id)
                    .Join(studentList,
                          e => e.StudentId,
                          s => s.Id,
                          (e, s) => s.GPA)
                    .DefaultIfEmpty(0m)
                    .Average()
            });
            Console.WriteLine("Average GPA per course:");
            foreach (var item in averageGpaPerCourse)
            {
                Console.WriteLine($"Course: {item.CourseTitle}, Average GPA: {item.AverageGPA:F2}");
            }

            Console.WriteLine("\n");

            // Sum - Total GPA of students by subject
            var totalGpaPerCourse = courseList.Select(course => new
            {
                CourseTitle = course.Title,
                TotalGPA = enrollmentList
                    .Where(e => e.CourseId == course.Id)
                    .Join(studentList,
                          e => e.StudentId,
                          s => s.Id,
                          (e, s) => s.GPA)
                    .DefaultIfEmpty(0m)
                    .Sum()
            });
            foreach (var item in totalGpaPerCourse)
            {
                Console.WriteLine($"Course: {item.CourseTitle}, Total GPA: {item.TotalGPA:F2}");
            }

            Console.WriteLine("\n");

            // Max - Highest GPA in the course
            var maxGpaPerCourse = courseList.Select(course => new
            {
                CourseTitle = course.Title,
                MaxGPA = enrollmentList
                    .Where(e => e.CourseId == course.Id)
                    .Join(studentList,
                          e => e.StudentId,
                          s => s.Id,
                          (e, s) => s.GPA)
                    .DefaultIfEmpty(0m)
                    .Max()
            });
            Console.WriteLine("Highest GPA per course:");
            foreach (var item in maxGpaPerCourse)
            {
                Console.WriteLine($"Course: {item.CourseTitle}, Highest GPA: {item.MaxGPA:F2}");
            }

            Console.WriteLine("\n");

            // Min - Lowest GPA in the course
            var minGpaPerCourse = courseList.Select(course => new
            {
                CourseTitle = course.Title,
                MinGPA = enrollmentList
                    .Where(e => e.CourseId == course.Id)
                    .Join(studentList,
                          e => e.StudentId,
                          s => s.Id,
                          (e, s) => s.GPA)
                    .DefaultIfEmpty(0m)
                    .Min()
            });
            Console.WriteLine("Lowest GPA per course:");
            foreach (var item in minGpaPerCourse)
            {
                Console.WriteLine($"Course: {item.CourseTitle}, Lowest GPA: {item.MinGPA:F2}");
            }


        }
    }
}
