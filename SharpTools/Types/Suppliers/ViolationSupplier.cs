using DerRobert28.SharpTools.Helpers;

namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ViolationSupplier: Supplier<Violation> {
	
		public static new ViolationSupplier of(Supplier<Violation> supplier)
			=> new ViolationSupplier(supplier);
		
		private ViolationSupplier(Supplier<Violation> supplier):
			base(supplier) {}

	}

}
