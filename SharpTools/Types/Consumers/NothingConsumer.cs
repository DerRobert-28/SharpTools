using DerRobert28.SharpTools.Helpers;
using System;

namespace DerRobert28.SharpTools.Types.Consumers {

	public class NothingConsumer: Consumer<Nothing> {

		public static NothingConsumer of(Consumer<Nothing> function)
			=> new NothingConsumer(function);
		
		private NothingConsumer(Consumer<Nothing> function):
			base(function) {}

	}

}
