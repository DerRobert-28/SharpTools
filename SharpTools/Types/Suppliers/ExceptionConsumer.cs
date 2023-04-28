﻿using System;

namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ExceptionSupplier: Supplier<Exception> {

		public static ExceptionSupplier of(Supplier<Exception> supplier)
			=> new ExceptionSupplier(supplier);
		
		private ExceptionSupplier(Supplier<Exception> supplier):
			base(supplier) {}

	}

}
