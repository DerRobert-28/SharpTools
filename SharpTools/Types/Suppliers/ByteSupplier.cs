namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ByteSupplier: Supplier<byte> {

		public static ByteSupplier of(Delegate supplier)
			=> new ByteSupplier(supplier);
		
		private ByteSupplier(Delegate supplier): base(supplier) {}

	}

}
