namespace DerRobert28.SharpTools.Types.Suppliers {

	public class FloatSupplier: Supplier<float> {

		public static new FloatSupplier of(Supplier<float> supplier)
			=> new FloatSupplier(supplier);
		
		private FloatSupplier(Supplier<float> supplier): base(supplier) {}

	}

}
