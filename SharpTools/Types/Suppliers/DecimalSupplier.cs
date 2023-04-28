namespace DerRobert28.SharpTools.Types.Suppliers {

	public class DecimalSupplier: Supplier<decimal> {

		public static DecimalSupplier of(Supplier<decimal> supplier)
			=> new DecimalSupplier(supplier);
		
		private DecimalSupplier(Supplier<decimal> supplier):
			base(supplier) {}

	}

}
