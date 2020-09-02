using System.Collections.Generic;
using kkukukuku.Services.Interfaces.srctest;
using kkukukuku.Entities.srctest;
using kkukukuku.Web.Models.srctest;
using MetaShare.Common.Core.CommonService;
using MetaShare.Common.Core.Entities;
using kkukukuku.Web.Models;

/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Web.Controllers.srctest
{
	public class Student1Controller:CommonController<Student1, IStudent1Service, Student1Model>
	{
		protected override string GetCurrentAreaPath()
		{
			 return "srctest_Student1";
		}


		protected override List<Student1> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<Student1> lists = this.Service.SelectBy(pagerSearchModel.Pager,new Student1 { Name = pagerSearchModel.Name }, student1 => student1.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
