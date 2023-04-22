namespace DerRobert28.SharpTools.Types.Suppliers {

	public class IntSupplier: Supplier<int> {

		public static IntSupplier of(Delegate supplier) => new IntSupplier(supplier);
		
		private IntSupplier(Delegate supplier): base(supplier) {}

	}

}
