using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using kkukukuku.Entities.srctest;
using MetaShare.Common.Core.Services;
using kkukukuku.Daos.Interfaces.srctest;
using kkukukuku.Services.Interfaces.srctest;

/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Services.srctest
{
	public class Student1Service : Service<Student1>, IStudent1Service
	{
		public Student1Service() : base(typeof (IStudent1Dao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
