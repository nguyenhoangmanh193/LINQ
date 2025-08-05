using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Join
    {
        public static void EmployeeDepartmentJoin(
           IEnumerable<Student> studentList,
           IEnumerable<Course> courseList,
           IEnumerable<Enrollment> enrollmentList)
        {
            // Method Syntax
            var query = studentList
               .Join(enrollmentList,
          student => student.Id,
          enrollment => enrollment.StudentId,
          (student, enrollment) => new { student, enrollment })
    .Join(courseList,
          se => se.enrollment.CourseId,
          course => course.Id,
          (se, course) => new
          {
              StudentName = se.student.FirstName + " " + se.student.LastName,
              CourseTitle = course.Title
          });

            foreach (var item in query)
            {
                Console.WriteLine($"Student: {item.StudentName,-20}, Course: {item.CourseTitle}");
            }

            // Query Syntax
            var query1 = from student in studentList
                        join enrollment in enrollmentList on student.Id equals enrollment.StudentId
                        join course in courseList on enrollment.CourseId equals course.Id
                        select new
                        {
                            StudentName = student.FirstName + " " + student.LastName,
                            CourseTitle = course.Title
                        };

            //foreach (var item in query1)
            //{
            //    Console.WriteLine($"Student: {item.StudentName}, Course: {item.CourseTitle}");
            //}


        }

        public static void EmployeeDepartmentGroupJoin(
           IEnumerable<Student> studentList,
           IEnumerable<Course> courseList,
           IEnumerable<Enrollment> enrollmentList)
        {
            // GroupJoin Operator Example - Method Syntax
            var query = studentList
                .GroupJoin(
                   enrollmentList,
                   student => student.Id,
                   enrollment => enrollment.StudentId,
                   (student, enrollments) => new
                   {
                     StudentName = student.FirstName + " " + student.LastName,
                     Courses = enrollments
                   .GroupJoin(
                     courseList,
                     enrollment => enrollment.CourseId,
                     course => course.Id,
                     (enrollment, courses) => courses.Select(c => c.Title).FirstOrDefault()
                    )
                   }
                 );

            foreach (var item in query)
            {
                Console.WriteLine($"Student: {item.StudentName}");
                foreach (var courseTitle in item.Courses)
                {
                    if (courseTitle != null)
                        Console.WriteLine($"    - Course: {courseTitle}");
                }
            }

            // GroupJoin Operator Example - Query Syntax
            var query1 =   
                from student in studentList
                join enrollment in enrollmentList
                     on student.Id equals enrollment.StudentId into studentEnrollments
                select new
                 {
                     StudentName = student.FirstName + " " + student.LastName,
                     Courses =
                        from enrollment in studentEnrollments
                        join course in courseList
                           on enrollment.CourseId equals course.Id into courseGroup
                        from course in courseGroup.DefaultIfEmpty()
                        select course?.Title
                 };

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Student: {item.StudentName}");
            //    // Display courses for each student
            //    foreach (var courseTitle in item.Courses)
            //    {
            //        if (courseTitle != null)
            //            Console.WriteLine($"     - Course: {courseTitle}");
            //    }
            //}

        }
    }
}
