namespace DerRobert28.SharpTools.Types.Suppliers {

	public class CharSupplier: Supplier<char> {

		public static CharSupplier of(Delegate supplier)
			=> new CharSupplier(supplier);
		
		private CharSupplier(Delegate supplier): base(supplier) {}

	}

}
