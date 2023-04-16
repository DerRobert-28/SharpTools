namespace DerRobert28.SharpTools.FunctionTypes.Suppliers {

	using System;

	public class ExceptionSupplier: Supplier<Exception> {

		public static ExceptionSupplier of(Supplier<Exception>.Delegate supplier)
			=> new ExceptionSupplier(supplier);
		
		private ExceptionSupplier(Supplier<Exception>.Delegate supplier): base(supplier) {}

	}

}
