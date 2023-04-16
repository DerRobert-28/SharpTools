namespace DerRobert28.SharpTools.FunctionTypes.Suppliers {

	public class StringSupplier: Supplier<string> {

		public static StringSupplier of(Supplier<string>.Delegate supplier)
			=> new StringSupplier(supplier);
		
		private StringSupplier(Supplier<string>.Delegate supplier): base(supplier) {}

	}

}
