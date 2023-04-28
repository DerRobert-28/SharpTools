namespace DerRobert28.SharpTools.Types.Consumers {

	public class IntConsumer: Consumer<int> {

		public static new IntConsumer of(Consumer<int> function)
			=> new IntConsumer(function);
		
		private IntConsumer(Consumer<int> function):
			base(function) {}

	}

}
