using DerRobert28.SharpTools.Types;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DerRobert28.Tests.SharpTools {
 
	[TestFixture]
	public class UserTests {

        [Test]
		public void UserNamedTest() {
			//
			//	Arrange:
			//
			const string EXPECTED_NAME = "Test User";
			//
			//	Act:
			//
			var actualUser = User.named(EXPECTED_NAME);
			//
			//	Assert:
			//
			Assert.AreEqual(EXPECTED_NAME, actualUser.getName());
		}

        [Test]
		public void UserGetNameTest() {
			//
			//	Arrange:
			//
			const string UNEXPECTED_NAME = "Unexpected Name";
			const string ACTUAL_NAME = "Actual Name";
			//
			//	Act:
			//
			var actualUser = User.named(ACTUAL_NAME);
			//
			//	Assert:
			//
			Assert.AreNotEqual(UNEXPECTED_NAME, actualUser.getName());
		}

	}

}
