﻿namespace DerRobert28.SharpTools.Types.Consumers {

	public class ShortConsumer: Consumer<short> {

		public static ShortConsumer of(Consumer<short> function)
			=> new ShortConsumer(function);
		
		private ShortConsumer(Consumer<short> function):
			base(function) {}

	}

}
