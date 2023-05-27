namespace DerRobert28.SharpTools.Types.Suppliers {


public class StringSupplier: Supplier<string> {

	public static new StringSupplier of(Supplier<string> supplier)
		=> new StringSupplier(supplier);
		
	private StringSupplier(Supplier<string> supplier): base(supplier) {}

}}
