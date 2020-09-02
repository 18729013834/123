using MetaShare.Common.Core.Daos;
using kkukukuku.Daos.Interfaces.srctest;
using kkukukuku.Daos.Mocks.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Daos.Mocks
{
	public class RegisterDaoMocks
	{
		public static void RegisterAll()
		{
			Register(DaoFactory.Instance, true);
		}

		public static void UnRegisterAll()
		{
			Register(DaoFactory.Instance, false);
		}

		public static void Register(DaoFactory factory, bool isRegister)
		{
			factory.Register(typeof(IcourseDao), new courseDaoMock(), isRegister);
			factory.Register(typeof(IStudent1Dao), new Student1DaoMock(), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
