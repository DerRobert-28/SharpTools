namespace DerRobert28.SharpTools.Types.Consumers {

	public class DoubleConsumer: Consumer<double> {

		public static new DoubleConsumer of(Consumer<double> function)
			=> new DoubleConsumer(function);
		
		private DoubleConsumer(Consumer<double> function):
			base(function) {}

	}

}
