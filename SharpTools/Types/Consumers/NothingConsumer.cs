namespace DerRobert28.SharpTools.Types.Consumers {

	public class NothingConsumer: Consumer<Nothing> {

		public static new NothingConsumer of(Consumer<Nothing> function)
			=> new NothingConsumer(function);
		
		private NothingConsumer(Consumer<Nothing> function):
			base(function) {}

	}

}
