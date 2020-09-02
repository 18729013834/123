using MetaShare.Common.Core.CommonService;
using kkukukuku.Services.Interfaces.srctest;
using kkukukuku.Services.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Services
{
	public class RegisterServices
	{
		public static void RegisterAll()
		{
			Register(ServiceFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(ServiceFactory.Instance, false);
		}

		public static void Register(ServiceFactory factory, bool isRegister)
		{
			factory.Register(typeof(IcourseService), new courseService(), isRegister);
			factory.Register(typeof(IStudent1Service), new Student1Service(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
