namespace DerRobert28.SharpTools.Types.Suppliers {

using DerRobert28.SharpTools.Types.Abstract.Classes;


public class ShortSupplier: TSupplier<ShortSupplier, short> {

	public static ShortSupplier of(Supplier<short> supplier)
		=> new ShortSupplier(supplier);
		
	private ShortSupplier(Supplier<short> supplier): base(supplier) {}

}}
