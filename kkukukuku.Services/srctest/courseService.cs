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
	public class courseService : Service<course>, IcourseService
	{
		public courseService() : base(typeof (IcourseDao))
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
