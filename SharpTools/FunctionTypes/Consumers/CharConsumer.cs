namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class CharConsumer: Consumer<char> {

		public static CharConsumer of(Consumer<char>.Delegate consumer)
			=> new CharConsumer(consumer);
		
		private CharConsumer(Consumer<char>.Delegate consumer): base(consumer) {}

	}

}
