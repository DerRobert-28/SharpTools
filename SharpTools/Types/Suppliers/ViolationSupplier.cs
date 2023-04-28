using DerRobert28.SharpTools.Helpers;
using System;

namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ViolationSupplier: Supplier<Violation> {

		public static ViolationSupplier of(Supplier<Violation> supplier)
			=> new ViolationSupplier(supplier);
		
		private ViolationSupplier(Supplier<Violation> supplier):
			base(supplier) {}

	}

}
