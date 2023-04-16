namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class DoubleConsumer: Consumer<double> {

		public static DoubleConsumer of(Consumer<double>.Delegate consumer)
			=> new DoubleConsumer(consumer);
		
		private DoubleConsumer(Consumer<double>.Delegate consumer): base(consumer) {}

	}

}
