using System;
using System.Collections.Generic;
using System.Web.Mvc;
using kkukukuku.Entities.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Web.Models.srctest
{
	public class Student1Model: CommonModel<Student1>
	{
		public string StudentName {get; set;}
		public int StudentNUM {get; set;}

		public override void PopulateFrom(Student1 entity)
		{
			if (entity == null) return;
			base.PopulateFrom(entity);

			this.StudentName = entity.StudentName;
			this.StudentNUM = entity.StudentNUM;
			/*add customized code between this region*/
			/*add customized code between this region*/
		}

		public override void PopulateTo(Student1 entity)
		{
			if (entity == null) return;
			base.PopulateTo(entity);

			entity.StudentName = this.StudentName;

			entity.StudentNUM = this.StudentNUM;

			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
