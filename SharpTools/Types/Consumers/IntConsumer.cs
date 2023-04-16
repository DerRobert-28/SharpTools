namespace DerRobert28.SharpTools.Types.Consumers {

	public class IntConsumer: Consumer<int> {

		public static IntConsumer of(Consumer<int>.Delegate function)
			=> new IntConsumer(function);
		
		private IntConsumer(Consumer<int>.Delegate function): base(function) {}

	}

}
