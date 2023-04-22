namespace DerRobert28.SharpTools.Types.Suppliers {

	using System;

	public class ExceptionSupplier: Supplier<Exception> {

		public static ExceptionSupplier of(Delegate supplier)
			=> new ExceptionSupplier(supplier);
		
		private ExceptionSupplier(Delegate supplier): base(supplier) {}

	}

}
