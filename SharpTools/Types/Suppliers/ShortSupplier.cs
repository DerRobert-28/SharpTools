using DerRobert28.SharpTools.Types.Abstract.Classes;

namespace DerRobert28.SharpTools.Types.Suppliers {

	public class ShortSupplier: TSupplier<ShortSupplier, short> {

		public static ShortSupplier of(Supplier<short> supplier)
			=> new ShortSupplier(supplier);
		
		private ShortSupplier(Supplier<short> supplier):
			base(supplier) {}

	}

}
