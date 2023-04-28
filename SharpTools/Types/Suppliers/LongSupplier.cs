namespace DerRobert28.SharpTools.Types.Suppliers {

	public class LongSupplier: Supplier<long> {

		public static LongSupplier of(Supplier<long> supplier)
			=> new LongSupplier(supplier);
		
		private LongSupplier(Supplier<long> supplier):
			base(supplier) {}

	}

}
