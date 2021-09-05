using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brushup_Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brushup_Student.Tests
{
	[TestClass()]
	public class StudentTests
	{
		//private Student st;

		//[TestInitialize]
		//public void Setup()
		//{
		Student st = new Student("Michael", "Slagelse", 3, Student.Gender.Male);
		//}

		[TestMethod()]
		public void ConstructorTest()
		{
			Assert.AreEqual("Michael", st.Name);
			Assert.AreEqual("Slagelse", st.Adress);
			Assert.AreEqual(3, st.Semester);
			Assert.AreEqual(Student.Gender.Male, st.StudentGender);
		}

		[TestMethod()]
		public void NameTest()
		{
			st.Name = "Julemand";
			Assert.AreEqual("Julemand", st.Name);
			Assert.ThrowsException<ArgumentOutOfRangeException>(() => st.Name = "N");

		}

		[TestMethod()]
		public void AdressTest()
		{
			Assert.ThrowsException<NullReferenceException>(() => st.Adress = null);
		}



		[TestMethod()]
		public void ToStringTest()
		{
		}
	}
}