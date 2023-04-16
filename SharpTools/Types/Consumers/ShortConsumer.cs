namespace DerRobert28.SharpTools.Types.Consumers {

	public class ShortConsumer: Consumer<short> {

		public static ShortConsumer of(Consumer<short>.Delegate function)
			=> new ShortConsumer(function);
		
		private ShortConsumer(Consumer<short>.Delegate function): base(function) {}

	}

}
