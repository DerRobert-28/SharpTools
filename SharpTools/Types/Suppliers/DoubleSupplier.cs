namespace DerRobert28.SharpTools.Types.Suppliers {

	public class DoubleSupplier: Supplier<double> {

		public static DoubleSupplier of(Delegate supplier)
			=> new DoubleSupplier(supplier);
		
		private DoubleSupplier(Delegate supplier): base(supplier) {}

	}

}
