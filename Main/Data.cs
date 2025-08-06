using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Program;

namespace Main
{
    internal class Data
    {
        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal GPA { get; set; }
            public bool IsEnrolled { get; set; }
        }

        public class Course
        {
            public int Id { get; set; }
            public string CourseCode { get; set; }
            public string Title { get; set; }
        }

        public class Enrollment
        {
            public int StudentId { get; set; }
            public int CourseId { get; set; }
        }


        public static List<Student> GetStudents()
        {
            return new List<Student>
    {
        new Student { Id = 1, FirstName = "Alice", LastName = "Nguyen", GPA = 3.8m, IsEnrolled = true },
        new Student { Id = 2, FirstName = "David", LastName = "Tran", GPA = 3.2m, IsEnrolled = true },
        new Student { Id = 3, FirstName = "Emily", LastName = "Le", GPA = 2.5m, IsEnrolled = false },
        new Student { Id = 4, FirstName = "Michael", LastName = "Pham", GPA = 3.9m, IsEnrolled = true },
        new Student { Id = 5, FirstName = "Sophia", LastName = "Hoang", GPA = 3.6m, IsEnrolled = true },
        new Student { Id = 6, FirstName = "John", LastName = "Vu", GPA = 2.8m, IsEnrolled = true },
        new Student { Id = 7, FirstName = "Anna", LastName = "Bui", GPA = 3.0m, IsEnrolled = true },
        new Student { Id = 8, FirstName = "Tom", LastName = "Do", GPA = 3.4m, IsEnrolled = true },
        new Student { Id = 9, FirstName = "Linda", LastName = "Phan", GPA = 3.7m, IsEnrolled = true },
        new Student { Id = 10, FirstName = "Kevin", LastName = "Nguyen", GPA = 2.9m, IsEnrolled = false },
        new Student { Id = 11, FirstName = "Grace", LastName = "Le", GPA = 3.3m, IsEnrolled = true },
        new Student { Id = 12, FirstName = "Brian", LastName = "Tran", GPA = 3.5m, IsEnrolled = true },
        new Student { Id = 13, FirstName = "Diana", LastName = "Hoang", GPA = 3.1m, IsEnrolled = false },
        new Student { Id = 14, FirstName = "Chris", LastName = "Pham", GPA = 2.7m, IsEnrolled = true },
        new Student { Id = 15, FirstName = "Olivia", LastName = "Vu", GPA = 3.9m, IsEnrolled = true }
    };
        }

        public static List<Course> GetCourses()
        {
            return new List<Course>
    {
        new Course { Id = 1, CourseCode = "CS101", Title = "Introduction to Computer Science" },
        new Course { Id = 2, CourseCode = "MATH202", Title = "Calculus II" },
        new Course { Id = 3, CourseCode = "ENG150", Title = "Academic Writing" },
        new Course { Id = 4, CourseCode = "PHYS101", Title = "General Physics" },
        new Course { Id = 5, CourseCode = "HIST300", Title = "Modern History" }
    };
        }

        public static List<Enrollment> GetEnrollments()
        {
            return new List<Enrollment>
    {
        new Enrollment { StudentId = 1, CourseId = 1 },
        new Enrollment { StudentId = 1, CourseId = 2 },
        new Enrollment { StudentId = 2, CourseId = 2 },
        new Enrollment { StudentId = 2, CourseId = 3 },
        new Enrollment { StudentId = 4, CourseId = 1 },
        new Enrollment { StudentId = 4, CourseId = 3 },
        new Enrollment { StudentId = 5, CourseId = 2 },
        new Enrollment { StudentId = 5, CourseId = 3 },
        new Enrollment { StudentId = 5, CourseId = 4 },
        new Enrollment { StudentId = 6, CourseId = 4 },
        new Enrollment { StudentId = 7, CourseId = 5 },
        new Enrollment { StudentId = 8, CourseId = 3 },
        new Enrollment { StudentId = 9, CourseId = 4 },
        new Enrollment { StudentId = 11, CourseId = 1 },
        new Enrollment { StudentId = 11, CourseId = 2 },
        new Enrollment { StudentId = 12, CourseId = 2 },
        new Enrollment { StudentId = 12, CourseId = 3 },
        new Enrollment { StudentId = 14, CourseId = 4 },
        new Enrollment { StudentId = 15, CourseId = 5 }
    };
        }

    }
}

