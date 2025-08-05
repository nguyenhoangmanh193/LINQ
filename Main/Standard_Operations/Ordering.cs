using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Main.Data;

namespace Main.Standard_Operations
{
    internal class Ordering
    {
        public static void OrderStudentsByGPA(
           IEnumerable<Student> studentList,
           IEnumerable<Course> courseList,
           IEnumerable<Enrollment> enrollmentList)
        {

            // Method Syntax
            var results = studentList
                .Join(enrollmentList,
                      student => student.Id,
                      enrollment => enrollment.StudentId,
                      (student, enrollment) => new { student, enrollment })
                .Join(courseList,
                      se => se.enrollment.CourseId,
                      course => course.Id,
                      (se, course) => new
                      {
                          StudentId = se.student.Id,
                          FullName = se.student.FirstName + " " + se.student.LastName,
                          GPA = se.student.GPA,
                          CourseId = course.Id,
                          CourseTitle = course.Title,
                          LastName = se.student.LastName
                      })
                .OrderBy(r => r.CourseId)
                .ThenByDescending(r => r.GPA)
                .ThenBy(r => r.LastName);

            foreach (var item in results)
            {
                Console.WriteLine($"{item.CourseTitle,-30} | {item.FullName,-20} | GPA: {item.GPA}");
            }


            // Query Syntax
            var results1 = from student in studentList
                          join enrollment in enrollmentList
                              on student.Id equals enrollment.StudentId
                          join course in courseList
                              on enrollment.CourseId equals course.Id
                          orderby course.Id, student.GPA descending, student.LastName
                          select new
                          {
                              StudentId = student.Id,
                              FullName = student.FirstName + " " + student.LastName,
                              GPA = student.GPA,
                              CourseId = course.Id,
                              CourseTitle = course.Title,
                              LastName = student.LastName
                          };

        }


    }
}
