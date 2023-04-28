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
			const string expectedName = "Test User";
			//
			//	Act:
			//
			var testUser = User.named(expectedName);
			//
			//	Assert:
			//
			Assert.AreEqual(testUser.getName(), expectedName);
		}

        [Test]
		public void UserGetNameTest() {
			//
			//	Arrange:
			//
			const string actualName = "Actual Name";
			const string unexpectedName = "Unexpected Name";
			//
			//	Act:
			//
			var testUser = User.named(actualName);
			//
			//	Assert:
			//
			Assert.AreNotEqual(testUser.getName(), unexpectedName);
		}

	}

}
