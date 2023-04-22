namespace DerRobert28.SharpTools.Types.Consumers {

	public class LongConsumer: Consumer<long> {

		public static LongConsumer of(Delegate function)
			=> new LongConsumer(function);
		
		private LongConsumer(Delegate function): base(function) {}

	}

}
