namespace DerRobert28.SharpTools.Types.Suppliers {

	public class StringSupplier: Supplier<string> {

		public static StringSupplier of(Supplier<string> supplier)
			=> new StringSupplier(supplier);
		
		private StringSupplier(Supplier<string> supplier):
			base(supplier) {}

	}

}
