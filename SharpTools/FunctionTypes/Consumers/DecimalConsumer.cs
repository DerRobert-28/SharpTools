namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class DecimalConsumer: Consumer<decimal> {

		public static DecimalConsumer of(Consumer<decimal>.Delegate consumer)
			=> new DecimalConsumer(consumer);
		
		private DecimalConsumer(Consumer<decimal>.Delegate consumer): base(consumer) {}

	}

}
