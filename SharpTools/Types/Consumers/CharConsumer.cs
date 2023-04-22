namespace DerRobert28.SharpTools.Types.Consumers {

	public class CharConsumer: Consumer<char> {

		public static CharConsumer of(Delegate function)
			=> new CharConsumer(function);
		
		private CharConsumer(Delegate function): base(function) {}

	}

}
