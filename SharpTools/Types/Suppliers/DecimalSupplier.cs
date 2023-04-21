﻿namespace DerRobert28.SharpTools.Types.Suppliers {

	public class DecimalSupplier: Supplier<decimal> {

		public static DecimalSupplier of(Supplier<decimal>.Delegate supplier)
			=> new DecimalSupplier(supplier);
		
		private DecimalSupplier(Supplier<decimal>.Delegate supplier): base(supplier) {}

	}

}