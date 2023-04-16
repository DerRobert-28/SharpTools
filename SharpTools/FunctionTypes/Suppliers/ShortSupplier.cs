namespace DerRobert28.SharpTools.FunctionTypes.Suppliers {

	public class ShortSupplier: Supplier<short> {

		public static ShortSupplier of(Supplier<short>.Delegate supplier)
			=> new ShortSupplier(supplier);
		
		private ShortSupplier(Supplier<short>.Delegate supplier): base(supplier) {}

	}

}
