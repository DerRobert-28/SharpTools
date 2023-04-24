namespace DerRobert28.SharpTools.Types.Suppliers {

	public class IntSupplier: Supplier<int> {

		public static IntSupplier of(Supplier<int> supplier)
			=> new IntSupplier(supplier);
		
		private IntSupplier(Supplier<int> supplier):
			base(supplier) {}

	}

}
