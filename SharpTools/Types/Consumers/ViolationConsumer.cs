using DerRobert28.SharpTools.Helpers;

namespace DerRobert28.SharpTools.Types.Consumers {

	public class ViolationConsumer: Consumer<Violation> {

		public static new ViolationConsumer of(Consumer<Violation> function)
			=> new ViolationConsumer(function);
		
		private ViolationConsumer(Consumer<Violation> function):
			base(function) {}

	}

}
