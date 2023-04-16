namespace DerRobert28.SharpTools.FunctionTypes.Suppliers {

	public class LongSupplier: Supplier<long> {

		public static LongSupplier of(Supplier<long>.Delegate supplier)
			=> new LongSupplier(supplier);
		
		private LongSupplier(Supplier<long>.Delegate supplier): base(supplier) {}

	}

}
