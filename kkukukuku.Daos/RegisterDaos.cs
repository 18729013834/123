using System;
using MetaShare.Common.Core.Daos;
using kkukukuku.Daos.Interfaces.srctest;
using kkukukuku.Daos.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Daos
{
	public class RegisterDaos
	{
		public static void RegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, true,sqlDialect,sqlDialectVersion);
		}

		public static void UnRegisterAll(Type sqlDialect, Type sqlDialectVersion)
		{
			Register(DaoFactory.Instance, false,sqlDialect,sqlDialectVersion);
		}

		public static void Register(DaoFactory factory, bool isRegister, Type sqlDialect, Type sqlDialectVersion)
		{
			factory.Register(typeof(IcourseDao), new courseDao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			factory.Register(typeof(IStudent1Dao), new Student1Dao(Activator.CreateInstance(sqlDialect) as SqlDialect), isRegister);
			/*add customized code between this region*/
			/*add customized code between this region*/
		}
	}
}
