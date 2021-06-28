using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student Tom = new Student();
            Tom.StudentName = "Tom";
            Tom.StudentId = 1234;
            Tom.NumberOfCredits = 1;
            Tom.Gpa = 4.0;

            Course Algebra = new Course();
            Algebra.AddCourseRosterNames("Tom");
            
        }
    }
}
