namespace DerRobert28.SharpTools.Types.Consumers {

	public class DecimalConsumer: Consumer<decimal> {

		public static DecimalConsumer of(Consumer<decimal>.Delegate function)
			=> new DecimalConsumer(function);
		
		private DecimalConsumer(Consumer<decimal>.Delegate function): base(function) {}

	}

}
