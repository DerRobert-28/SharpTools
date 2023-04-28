using DerRobert28.SharpTools.Types;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DerRobert28.Tests.SharpTools {
 
	[TestFixture]
	public class UserTests {

        [Test]
		public void UserNamedTest() {
			const string testUserName = "Test User";
			var testUser = User.named(testUserName);

			Assert.AreEqual(testUser.getName(), testUserName);
		}


        [Test]
		public void UserGetNameTest() {
			var testUser = User.named("True Man");

			Assert.AreNotEqual(testUser.getName(), "False Man");
		}

	}

}
