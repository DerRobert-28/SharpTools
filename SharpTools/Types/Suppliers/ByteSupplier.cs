namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ByteSupplier: Supplier<byte> {

		public static ByteSupplier of(Supplier<byte> supplier)
			=> new ByteSupplier(supplier);
		
		private ByteSupplier(Supplier<byte> supplier):
			base(supplier) {}

	}

}
