using System;
using System.Collections.Generic;
using NUnit.Framework;
using kkukukuku.Entities.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.TestData.srctest
{
	public class courseTestData
	{
		public const int courseCount = 3;
		/*add customized code between this region*/
		/*add customized code between this region*/

		 public static List<course> Createcourse()
		{
			return new List<course>
			{
				Createcourse1(),
				Createcourse2(),
				Createcourse3(),
			};
		}

		 public static course Createcourse1()
		{
			return new course
			{
					Id = 1, 
					Description = string.Empty, 
					CourseNumber = 0, 
					Name = string.Empty, 
					CourseName = string.Empty, 
			};
		}
		 public static course Createcourse2()
		{
			return new course
			{
					Id = 2, 
					Description = string.Empty, 
					CourseNumber = 0, 
					Name = string.Empty, 
					CourseName = string.Empty, 
			};
		}
		 public static course Createcourse3()
		{
			return new course
			{
					Id = 3, 
					Description = string.Empty, 
					CourseNumber = 0, 
					Name = string.Empty, 
					CourseName = string.Empty, 
			};
		}
		public static void AssertAreEqual(course expected, course actual)
		{
			Assert.AreEqual(expected.Description, actual.Description);
			Assert.AreEqual(expected.CourseNumber, actual.CourseNumber);
			Assert.AreEqual(expected.Name, actual.Name);
			Assert.AreEqual(expected.CourseName, actual.CourseName);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
