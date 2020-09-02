using System;
using System.Collections.Generic;
using NUnit.Framework;
using kkukukuku.Entities.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.TestData.srctest
{
	public class Student1TestData
	{
		public const int Student1Count = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<Student1> CreateStudent1()
		{
			return new List<Student1>
			{
				CreateStudent11(),
				CreateStudent12(),
				CreateStudent13(),
			};
		}

		 public static Student1 CreateStudent11()
		{
			return new Student1
			{
					Id = 1, 
					StudentName = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
					StudentNUM = 0, 
			};
		}
		 public static Student1 CreateStudent12()
		{
			return new Student1
			{
					Id = 2, 
					StudentName = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
					StudentNUM = 0, 
			};
		}
		 public static Student1 CreateStudent13()
		{
			return new Student1
			{
					Id = 3, 
					StudentName = string.Empty, 
					Description = string.Empty, 
					Name = string.Empty, 
					StudentNUM = 0, 
			};
		}
		public static void AssertAreEqual(Student1 expected, Student1 actual)
		{
			Assert.AreEqual(expected.StudentName, actual.StudentName);
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.StudentNUM, actual.StudentNUM);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
