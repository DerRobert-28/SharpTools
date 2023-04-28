namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ShortSupplier: Supplier<short> {

		public static ShortSupplier of(Supplier<short> supplier)
			=> new ShortSupplier(supplier);
		
		private ShortSupplier(Supplier<short> supplier):
			base(supplier) {}

	}

}
