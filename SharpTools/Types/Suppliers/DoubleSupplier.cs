namespace DerRobert28.SharpTools.Types.Suppliers {

	public class DoubleSupplier: Supplier<double> {

		public static DoubleSupplier of(Supplier<double> supplier)
			=> new DoubleSupplier(supplier);
		
		private DoubleSupplier(Supplier<double> supplier):
			base(supplier) {}

	}

}
