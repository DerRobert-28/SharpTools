namespace DerRobert28.SharpTools.Types.Suppliers {

	public class DecimalSupplier: Supplier<decimal> {

		public static DecimalSupplier of(Delegate supplier)
			=> new DecimalSupplier(supplier);
		
		private DecimalSupplier(Delegate supplier): base(supplier) {}

	}

}
