namespace DerRobert28.SharpTools.FunctionTypes.Suppliers {

	public class IntSupplier: Supplier<int> {

		public static IntSupplier of(Supplier<int>.Delegate supplier) => new IntSupplier(supplier);
		
		private IntSupplier(Supplier<int>.Delegate supplier): base(supplier) {}

	}

}
