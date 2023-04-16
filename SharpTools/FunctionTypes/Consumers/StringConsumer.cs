namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class StringConsumer: Consumer<string> {

		public static StringConsumer of(Consumer<string>.Delegate consumer)
			=> new StringConsumer(consumer);
		
		private StringConsumer(Consumer<string>.Delegate consumer): base(consumer) {}

	}

}
