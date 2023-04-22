namespace DerRobert28.SharpTools.Types.Suppliers {

	public class FloatSupplier: Supplier<float> {

		public static FloatSupplier of(Delegate supplier)
			=> new FloatSupplier(supplier);
		
		private FloatSupplier(Delegate supplier): base(supplier) {}

	}

}
