﻿using System.Collections.Generic;
using NUnit.Framework;
using System;
using kkukukuku.Daos.Interfaces.srctest;
using kkukukuku.Daos.DataSchema.srctest;
using kkukukuku.TestData.srctest;
using kkukukuku.Daos.Tests.Common;
using kkukukuku.Entities.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Daos.Tests.srctest
{
	public class courseDaoTest : CommonDaoTest<course, IcourseDao, courseDdlBuilder>
	{
		public courseDaoTest() : base(courseTestData.Createcourse())
		{
		}

		[TestCase]
		public void SelectAllTest()
		{
			Assert.AreEqual(courseTestData.courseCount, this.Dao.SelectAll(this.Context).Count);
		}

		[TestCase]
		public void SelectByIdTest()
		{
			course item = courseTestData.Createcourse1();
			course find = this.Dao.SelectById(this.Context, item);

			Assert.AreEqual(item.Id, find.Id);
			courseTestData.AssertAreEqual(item, find);
		}

		[TestCase]
		public void InsertTest()
		{
			course item = new course
			{
				Description = string.Empty, 
				CourseNumber = 0, 
				Name = string.Empty, 
				CourseName = string.Empty, 
			};
			int affectedRows = this.Dao.Insert(this.Context, item);
			Assert.AreEqual(1, affectedRows);

			course find = this.Dao.SelectById(this.Context, item);
			courseTestData.AssertAreEqual(item, find);

			List<course> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(courseTestData.courseCount + 1, items.Count);
		}

		[TestCase]
		public void UpdateTest()
		{
			course item = courseTestData.Createcourse1();
			course beforeUpdate = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforeUpdate);
			beforeUpdate.Description = string.Empty;

			this.Dao.Update(this.Context, beforeUpdate);

			course afterUpdate = this.Dao.SelectById(this.Context, beforeUpdate);
			courseTestData.AssertAreEqual(beforeUpdate, afterUpdate);
		}

		[TestCase]
		public void DeleteTest()
		{
			course item = courseTestData.Createcourse1();
			course beforedelete = this.Dao.SelectById(this.Context, item);
			Assert.IsNotNull(beforedelete);

			int affectedRows = this.Dao.Delete(this.Context, beforedelete);
			Assert.AreEqual(1, affectedRows);

			course afterDelete = this.Dao.SelectById(this.Context, beforedelete);
			Assert.IsNull(afterDelete);

			List<course> items = this.Dao.SelectAll(this.Context);
			Assert.AreEqual(courseTestData.courseCount - 1, items.Count);
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
