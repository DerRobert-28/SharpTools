namespace DerRobert28.SharpTools.Types.Suppliers {

	public class StringSupplier: Supplier<string> {

		public static StringSupplier of(Delegate supplier)
			=> new StringSupplier(supplier);
		
		private StringSupplier(Delegate supplier): base(supplier) {}

	}

}
