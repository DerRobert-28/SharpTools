namespace DerRobert28.SharpTools.Types.Consumers {

	public class ObjectConsumer: Consumer<object> {

		public static ObjectConsumer of(Consumer<object>.Delegate function)
			=> new ObjectConsumer(function);
		
		private ObjectConsumer(Consumer<object>.Delegate function): base(function) {}

	}

}
