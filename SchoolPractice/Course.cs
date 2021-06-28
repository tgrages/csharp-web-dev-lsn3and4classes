using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
	class Course
	{
		private List<string> _courseRosterList = new List<string>();
		private string _courseName;
		private int _courseSize;

		public void AddCourseRosterNames(string StudentName)
		{
			_courseRosterList.Add(StudentName);

			foreach (string names in _courseRosterList)
			{
				Console.WriteLine(names);
			}
		}

		public string CourseName
		{
			get { return _courseName; }
			set { _courseName = value; }
		}

		public int CourseSize
		{
			get { return _courseSize; }
			set { _courseSize = value; }
		}	



	}
}
