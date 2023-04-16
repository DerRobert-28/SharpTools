namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class ObjectConsumer: Consumer<object> {

		public static ObjectConsumer of(Consumer<object>.Delegate consumer)
			=> new ObjectConsumer(consumer);
		
		private ObjectConsumer(Consumer<object>.Delegate consumer): base(consumer) {}

	}

}
