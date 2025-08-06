
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

            // Quantifiers ( Any, All, Contains )   
            //Quantifier.QuantifierDemo(students, courses, enrollments);

            // Element Operators ( First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault )
            //Element.ElementDemo(students, courses, enrollments);

            // Partitioning (Skip, SkipWhile, Take, TakeWhile )
            //Partitioning.PartitioningDemo(students, enrollments);

            // Generation ( Range, Repeat )
            //Generation.Generations();

            // Set Operators ( Distinct, Union, Intersect, Except )
            //Set.SetDemo(students);

            // Aggregation ( Count, Sum, Average, Min, Max )
            //Aggregate.AggregateDemo(students, courses, enrollments);

            // Conversion ( Cast, OfType, ToArray, ToList, ToDictionary )
            //Conversion.ConversionDemo(students, courses, enrollments);
        }


    }
}