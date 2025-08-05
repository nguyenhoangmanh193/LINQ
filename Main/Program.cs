
using Main.Standard_Operations;
using static Main.Data;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Data.GetStudents();
            var courses = Data.GetCourses();
            var enrollments = Data.GetEnrollments();

            // Restriction - Projection ( Select and Where Operators )
            //Restriction_Projection.GetGPAGood(students);

            // Join
            //Join.EmployeeDepartmentJoin(students, courses, enrollments);
            //Join.EmployeeDepartmentGroupJoin(students, courses, enrollments);

            // Ordering  ( OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse )
            //Ordering.OrderStudentsByGPA(students, courses, enrollments);

            // Grouping ( GroupBy, ToLookup )
            //Grouping.GroupStudentsByEnrollmentStatus(students);

            

            
        }


    }
}