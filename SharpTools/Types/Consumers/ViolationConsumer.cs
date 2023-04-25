using DerRobert28.SharpTools.Helpers;
using System;

namespace DerRobert28.SharpTools.Types.Consumers {

	public class ViolationConsumer: Consumer<Violation> {

		public static ViolationConsumer of(Consumer<Violation> function)
			=> new ViolationConsumer(function);
		
		private ViolationConsumer(Consumer<Violation> function):
			base(function) {}

	}

}
