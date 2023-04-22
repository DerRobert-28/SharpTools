namespace DerRobert28.SharpTools.Types.Consumers {

	public class ShortConsumer: Consumer<short> {

		public static ShortConsumer of(Delegate function)
			=> new ShortConsumer(function);
		
		private ShortConsumer(Delegate function): base(function) {}

	}

}
