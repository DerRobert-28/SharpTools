namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ObjectSupplier: Supplier<object> {

		public static ObjectSupplier of(Delegate supplier)
			=> new ObjectSupplier(supplier);
		
		private ObjectSupplier(Delegate supplier): base(supplier) {}

	}

}
