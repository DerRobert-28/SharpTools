﻿namespace DerRobert28.SharpTools.Types.Consumers {

	public class LongConsumer: Consumer<long> {

		public static LongConsumer of(Consumer<long> function)
			=> new LongConsumer(function);
		
		private LongConsumer(Consumer<long> function):
			base(function) {}

	}

}
