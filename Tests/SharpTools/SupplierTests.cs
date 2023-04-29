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
			const int EXPECTED_NUMBER = 12;
			Func<int> receiveNumber = () => EXPECTED_NUMBER;
			//
			//	Act:
			//
			var actualSupplier = Supplier<int>.of(receiveNumber);
			//
			//	Assert:
			//
			Assert.AreEqual(EXPECTED_NUMBER, actualSupplier.get());
		}

		[Test]
		public void SupplierOfSupplierTest() {
			//
			//	Arrange:
			//
			const int EXPECTED_NUMBER = 34;
			var numberSupplier = Supplier<int>.of(() => EXPECTED_NUMBER);
			//
			//	Act:
			//
			var actualResult = numberSupplier.get();
			//
			//	Assert:
			//
			Assert.AreEqual(EXPECTED_NUMBER, actualResult);
		}

	}

}
