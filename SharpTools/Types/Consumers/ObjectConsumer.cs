namespace DerRobert28.SharpTools.Types.Consumers {

	public class ObjectConsumer: Consumer<object> {

		public static ObjectConsumer of(Consumer<object> function)
			=> new ObjectConsumer(function);
		
		private ObjectConsumer(Consumer<object> function):
			base(function) {}

	}

}
