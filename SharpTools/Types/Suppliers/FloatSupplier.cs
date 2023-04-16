namespace DerRobert28.SharpTools.Types.Suppliers {

	public class FloatSupplier: Supplier<float> {

		public static FloatSupplier of(Supplier<float>.Delegate supplier)
			=> new FloatSupplier(supplier);
		
		private FloatSupplier(Supplier<float>.Delegate supplier): base(supplier) {}

	}

}
