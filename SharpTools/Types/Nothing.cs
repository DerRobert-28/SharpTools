using DerRobert28.SharpTools.Helpers;

namespace DerRobert28.SharpTools.Types {

	public sealed class Nothing {

		public static object get()
			=> null;

		public static T get<T>()
			=> Caster<T>.of(null);

		private Nothing() {}


	}

}
