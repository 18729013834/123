using MetaShare.Common.Core.Daos;
using kkukukuku.Entities.srctest;
using kkukukuku.Daos.Interfaces.srctest;
using kkukukuku.TestData.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Daos.Mocks.srctest
{
	public class courseDaoMock : MockDao<course>, IcourseDao
	{
		public courseDaoMock() : base(courseTestData.Createcourse())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
