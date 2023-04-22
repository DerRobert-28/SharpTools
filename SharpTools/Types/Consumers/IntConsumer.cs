namespace DerRobert28.SharpTools.Types.Consumers {

	public class IntConsumer: Consumer<int> {

		public static IntConsumer of(Delegate function)
			=> new IntConsumer(function);
		
		private IntConsumer(Delegate function): base(function) {}

	}

}
