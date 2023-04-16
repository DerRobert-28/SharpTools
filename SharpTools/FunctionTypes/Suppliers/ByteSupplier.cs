namespace DerRobert28.SharpTools.FunctionTypes.Suppliers {

	public class ByteSupplier: Supplier<byte> {

		public static ByteSupplier of(Supplier<byte>.Delegate supplier)
			=> new ByteSupplier(supplier);
		
		private ByteSupplier(Supplier<byte>.Delegate supplier): base(supplier) {}

	}

}
