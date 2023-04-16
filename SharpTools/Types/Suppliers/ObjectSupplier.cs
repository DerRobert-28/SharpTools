namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ObjectSupplier: Supplier<object> {

		public static ObjectSupplier of(Supplier<object>.Delegate supplier)
			=> new ObjectSupplier(supplier);
		
		private ObjectSupplier(Supplier<object>.Delegate supplier): base(supplier) {}

	}

}
