namespace DerRobert28.SharpTools.Types.Consumers {

	public class StringConsumer: Consumer<string> {

		public static StringConsumer of(Delegate function)
			=> new StringConsumer(function);
		
		private StringConsumer(Delegate function): base(function) {}

	}

}
