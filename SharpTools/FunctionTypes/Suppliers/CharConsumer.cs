namespace DerRobert28.SharpTools.FunctionTypes.Suppliers {

	public class CharSupplier: Supplier<char> {

		public static CharSupplier of(Supplier<char>.Delegate supplier)
			=> new CharSupplier(supplier);
		
		private CharSupplier(Supplier<char>.Delegate supplier): base(supplier) {}

	}

}
