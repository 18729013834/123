using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Web.Controllers.srctest
{
	public class srctestAreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.MapRoute(
			"srctest",
			"srctest/{controller}/{action}/{id}",
			new {action = "Index", id = UrlParameter.Optional},
			namespaces:new[]  {"kkukukuku.Web.Controllers.srctest"});
		}

		public override string AreaName
		{
			get { return "srctest"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
