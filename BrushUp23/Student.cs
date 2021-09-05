using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Brushup_Student
{
	public class Student
	{
		public enum Gender
		{
			Male = 0,
			Female = 1
		};

		#region Instancefields
		private string _name;
		private string _adress;
		private int _semester;
		private Gender _studentGender;
		#endregion


		public Student(string name, string adress, int semester, Gender studentGender)
		{
			_name = name;
			_adress = adress;
			_semester = semester;
			_studentGender = studentGender;
		}

		public override string ToString()
		{
			return base.ToString();
		}

		#region Properties
		public string Adress
		{
			get { return _adress; }
			set
			{
				if (value.Equals(null))
				{
					throw new NullReferenceException(("Adress cannot be null"));
				}
				_adress = value;
			}
		}

		public string Name
		{
			get { return _name; }
			set
			{
				if (value.Length < 2)
				{
					throw new ArgumentOutOfRangeException("Name must be at least 2 characters");
				}
				_name = value;
			}
		}

		public int Semester
		{
			get { return _semester; }
			set
			{
				if (value < 1 || value > 8)
				{
					throw new Exception("Semester must be 1-8");
				}
				_semester = value;
			}
		}

		public Gender StudentGender
		{
			get { return _studentGender; }
			set { _studentGender = value; }
		}
		#endregion
	}
}