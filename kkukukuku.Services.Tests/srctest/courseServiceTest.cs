using System;
using System.Collections.Generic;
using NUnit.Framework;
using kkukukuku.Entities.srctest;
using kkukukuku.TestData.srctest;
using kkukukuku.Services.Tests.Common;
using kkukukuku.Services.Interfaces.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Services.Tests.srctest
{

	[TestFixture]
	public class courseServiceTest : CommonServiceTest<course, IcourseService>
	{
		[TestCase]
		public void SelectAllTest()
		{
			List<course> items = this.Service.SelectAll();
			Assert.AreEqual(courseTestData.courseCount, items.Count);
		}

		[TestCase]
		public void SelectByTest()
		{
			course itemTest = courseTestData.Createcourse1();

			List<course> find = this.Service.SelectBy(new course {Description = itemTest.Description}, new List<string> {"Description"});
			Assert.IsNotNull(find);

			foreach (course item in find)
			{
				Assert.AreEqual(itemTest.Description, item.Description);
			}
		}

		[TestCase]
		public void SelectByIdTest()
		{
			course itemTest = courseTestData.Createcourse1();

			course find = this.Service.SelectById(new course {Id = itemTest.Id});
			Assert.IsNotNull(find);

			courseTestData.AssertAreEqual(itemTest, find);
		}

		[TestCase]
		public void DeleteTest()
		{
			course itemTest = courseTestData.Createcourse2();
			int affectedRows = this.Service.Delete(itemTest, true);

			List<course> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, courseTestData.courseCount - 1);
			Assert.AreEqual(-1, affectedRows);
		}

		[TestCase]
		public void InsertTest()
		{
			course itemTest = new course
			{
				Description = string.Empty, 
				CourseNumber = 0, 
				Name = string.Empty, 
				CourseName = string.Empty, 
			};

			int affectedRows = this.Service.Insert(itemTest, true);

			List<course> items = this.Service.SelectAll();
			Assert.AreEqual(items.Count, courseTestData.courseCount + 1);
			Assert.AreEqual(1, affectedRows);
		}

		[TestCase]
		public void UpdateTest()
		{
			course itemTest = courseTestData.Createcourse1();

			course beforeUpdate = this.Service.SelectById(new course {Id = itemTest.Id});
			beforeUpdate.Description = string.Empty ;
			this.Service.Update(beforeUpdate, true);

			course afterUpdate = this.Service.SelectById(new course {Id = itemTest.Id});
			courseTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}

}
