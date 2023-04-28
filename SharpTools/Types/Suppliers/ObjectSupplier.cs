namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ObjectSupplier: Supplier<object> {

		public static new ObjectSupplier of(Supplier<object> supplier)
			=> new ObjectSupplier(supplier);
		
		private ObjectSupplier(Supplier<object> supplier):
			base(supplier) {}

	}

}
