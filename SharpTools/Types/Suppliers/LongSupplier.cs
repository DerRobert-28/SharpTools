namespace DerRobert28.SharpTools.Types.Suppliers {

	public class LongSupplier: Supplier<long> {

		public static LongSupplier of(Delegate supplier)
			=> new LongSupplier(supplier);
		
		private LongSupplier(Delegate supplier): base(supplier) {}

	}

}
