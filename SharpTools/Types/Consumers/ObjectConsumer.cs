namespace DerRobert28.SharpTools.Types.Consumers {

	public class ObjectConsumer: Consumer<object> {

		public static ObjectConsumer of(Delegate function)
			=> new ObjectConsumer(function);
		
		private ObjectConsumer(Delegate function): base(function) {}

	}

}
