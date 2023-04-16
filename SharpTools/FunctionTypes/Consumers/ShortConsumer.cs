namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class ShortConsumer: Consumer<short> {

		public static ShortConsumer of(Consumer<short>.Delegate consumer)
			=> new ShortConsumer(consumer);
		
		private ShortConsumer(Consumer<short>.Delegate consumer): base(consumer) {}

	}

}
