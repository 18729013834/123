using MetaShare.Common.Core.Daos;
using kkukukuku.Entities.srctest;
using kkukukuku.Daos.Interfaces.srctest;
using kkukukuku.TestData.srctest;
/*add customized code between this region*/
/*add customized code between this region*/

namespace kkukukuku.Daos.Mocks.srctest
{
	public class Student1DaoMock : MockDao<Student1>, IStudent1Dao
	{
		public Student1DaoMock() : base(Student1TestData.CreateStudent1())
		{
		}
		/*add customized code between this region*/
		/*add customized code between this region*/
	}
}
