namespace DerRobert28.SharpTools.Types.Consumers {

	public class DecimalConsumer: Consumer<decimal> {

		public static DecimalConsumer of(Delegate function)
			=> new DecimalConsumer(function);
		
		private DecimalConsumer(Delegate function): base(function) {}

	}

}
