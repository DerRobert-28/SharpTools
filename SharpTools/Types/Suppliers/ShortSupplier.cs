namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ShortSupplier: Supplier<short> {

		public static ShortSupplier of(Delegate supplier)
			=> new ShortSupplier(supplier);
		
		private ShortSupplier(Delegate supplier): base(supplier) {}

	}

}
