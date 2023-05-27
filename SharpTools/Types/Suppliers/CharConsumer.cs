namespace DerRobert28.SharpTools.Types.Suppliers {


public class CharSupplier: Supplier<char> {

	public static new CharSupplier of(Supplier<char> supplier)
		=> new CharSupplier(supplier);

	private CharSupplier(Supplier<char> supplier): base(supplier) {}

}}
