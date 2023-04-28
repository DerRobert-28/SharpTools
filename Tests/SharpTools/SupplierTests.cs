using DerRobert28.SharpTools.Types;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

namespace DerRobert28.Tests.SharpTools {
 
	[TestFixture]
	public class SupplierTests {

        [Test]
		public void SupplierOfFuncTest() {
			//
			//	Arrange:
			//
			Func<int> receiveOne = () => 1;
			Func<int> receiveTwo = () => 2;
			Func<int> receiveThree = () => 3;
			//
			//	Act:
			//
			var oneSupplier = Supplier<int>.of(receiveOne);
			var twoSupplier = Supplier<int>.of(receiveTwo);
			var threeSupplier = Supplier<int>.of(receiveThree);
			//
			//	Assert:
			//
			Assert.AreEqual(oneSupplier.get(), 1);
			Assert.AreEqual(twoSupplier.get(), 2);
			Assert.AreEqual(threeSupplier.get(), 3);
		}

	}

}
