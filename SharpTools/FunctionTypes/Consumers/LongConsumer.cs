namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class LongConsumer: Consumer<long> {

		public static LongConsumer of(Consumer<long>.Delegate consumer)
			=> new LongConsumer(consumer);
		
		private LongConsumer(Consumer<long>.Delegate consumer): base(consumer) {}

	}

}
