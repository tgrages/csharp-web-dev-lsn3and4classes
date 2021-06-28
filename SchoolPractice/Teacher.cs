using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
	class Teacher
	{
		private string _firstName;
		private string _lastName;
		private string _subject;
		private int _yearsTeaching;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		public string Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}

		public int YearsTeaching
		{
			get { return _yearsTeaching; }
			set { _yearsTeaching = value; }
		}
	}
}
