namespace DerRobert28.SharpTools.Types.Suppliers {

	public class CharSupplier: Supplier<char> {

		public static CharSupplier of(Supplier<char> supplier)
			=> new CharSupplier(supplier);
		
		private CharSupplier(Supplier<char> supplier):
			base(supplier) {}

	}

}
