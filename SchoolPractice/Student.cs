using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string _name;
        private int _studentId;
        private int _numberOfCredits;
        private double _gpa;

        //need to get/set all the fields
        public string StudentName
        {
            get { return _name; }
            set { _name = value; }
        }

        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public int NumberOfCredits
        {
            get { return _numberOfCredits; }
            set { _numberOfCredits = value; }
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }       


    }

   
}
