namespace DerRobert28.SharpTools.Types.Consumers {

	public class DoubleConsumer: Consumer<double> {

		public static DoubleConsumer of(Consumer<double>.Delegate function)
			=> new DoubleConsumer(function);
		
		private DoubleConsumer(Consumer<double>.Delegate function): base(function) {}

	}

}
