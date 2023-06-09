﻿namespace DerRobert28.SharpTools.Types.Suppliers {


public class NothingSupplier: Supplier<Nothing> {

	public static new NothingSupplier of(Supplier<Nothing> supplier)
		=> new NothingSupplier(supplier);
		
	private NothingSupplier(Supplier<Nothing> supplier): base(supplier) {}

}}
