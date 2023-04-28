﻿namespace DerRobert28.SharpTools.Types.Consumers {

	public class DecimalConsumer: Consumer<decimal> {

		public static DecimalConsumer of(Consumer<decimal> function)
			=> new DecimalConsumer(function);
		
		private DecimalConsumer(Consumer<decimal> function):
			base(function) {}

	}

}
