namespace DerRobert28.SharpTools.Types.Consumers {

	public class DoubleConsumer: Consumer<double> {

		public static DoubleConsumer of(Delegate function)
			=> new DoubleConsumer(function);
		
		private DoubleConsumer(Delegate function): base(function) {}

	}

}
