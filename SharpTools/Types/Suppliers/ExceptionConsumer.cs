namespace DerRobert28.SharpTools.Types.Suppliers {

using System;


public class ExceptionSupplier: Supplier<Exception> {

	public static new ExceptionSupplier of(Supplier<Exception> supplier)
		=> new ExceptionSupplier(supplier);
		
	private ExceptionSupplier(Supplier<Exception> supplier): base(supplier) {}

}}
