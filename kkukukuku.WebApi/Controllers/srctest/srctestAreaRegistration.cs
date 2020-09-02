using System.Web.Http;
using System.Web.Mvc;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.WebApi.Controllers.srctest
{
	public class srctestAreaRegistration:AreaRegistration
	{
		public override void RegisterArea(AreaRegistrationContext context)
		{
			context.Routes.MapHttpRoute(
			name:"srctest",
			routeTemplate:"srctest/{controller}/{action}/{id}",
			defaults:new 
			{
				area = "srctest",
				action = "Index",
				id = UrlParameter.Optional,
				namespaceName = new[] {"kkukukuku.WebApi.Controllers.srctest"}
			});
		}

		public override string AreaName
		{
			get { return "srctest"; }
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
