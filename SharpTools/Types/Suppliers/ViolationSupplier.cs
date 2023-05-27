namespace DerRobert28.SharpTools.Types.Suppliers {

using DerRobert28.SharpTools.Helpers;


public class ViolationSupplier: Supplier<Violation> {
	
	public static new ViolationSupplier of(Supplier<Violation> supplier)
		=> new ViolationSupplier(supplier);
		
	private ViolationSupplier(Supplier<Violation> supplier): base(supplier) {}

}}
