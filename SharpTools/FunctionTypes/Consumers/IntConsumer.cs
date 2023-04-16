namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class IntConsumer: Consumer<int> {

		public static IntConsumer of(Consumer<int>.Delegate consumer)
			=> new IntConsumer(consumer);
		
		private IntConsumer(Consumer<int>.Delegate consumer): base(consumer) {}

	}

}
