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
	public class courseController:CommonController<course, IcourseService, courseModel>
	{
		protected override string GetCurrentAreaPath()
		{
			 return "srctest_course";
		}


		protected override List<course> GetBySearchModel(SearchModel pagerSearchModel)
        {
	        if (pagerSearchModel == null) return this.GetPagerData(new Pager { PageIndex = 1, PageSize = PageSize });

            List<course> lists = this.Service.SelectBy(pagerSearchModel.Pager,new course { Name = pagerSearchModel.Name }, course => course.Name.Contains(pagerSearchModel.Name));
        return lists;
	}

	/*add customized code between this region*/
	/*add customized code between this region*/
}
}
