namespace DerRobert28.SharpTools.Types.Consumers {

	public class CharConsumer: Consumer<char> {

		public static CharConsumer of(Consumer<char>.Delegate function)
			=> new CharConsumer(function);
		
		private CharConsumer(Consumer<char>.Delegate function): base(function) {}

	}

}
