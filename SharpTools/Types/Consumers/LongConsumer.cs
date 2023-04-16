namespace DerRobert28.SharpTools.Types.Consumers {

	public class LongConsumer: Consumer<long> {

		public static LongConsumer of(Consumer<long>.Delegate function)
			=> new LongConsumer(function);
		
		private LongConsumer(Consumer<long>.Delegate function): base(function) {}

	}

}
