namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class FloatConsumer: Consumer<float> {

		public static FloatConsumer of(Consumer<float>.Delegate consumer)
			=> new FloatConsumer(consumer);
		
		private FloatConsumer(Consumer<float>.Delegate consumer): base(consumer) {}

	}

}
