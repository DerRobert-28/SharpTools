namespace DerRobert28.SharpTools.Types.Consumers {

	public class StringConsumer: Consumer<string> {

		public static StringConsumer of(Consumer<string>.Delegate function)
			=> new StringConsumer(function);
		
		private StringConsumer(Consumer<string>.Delegate function): base(function) {}

	}

}
