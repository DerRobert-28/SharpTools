namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	public class ByteConsumer: Consumer<byte> {

		public static ByteConsumer of(Consumer<byte>.Delegate consumer)
			=> new ByteConsumer(consumer);
		
		private ByteConsumer(Consumer<byte>.Delegate consumer): base(consumer) {}

	}

}
