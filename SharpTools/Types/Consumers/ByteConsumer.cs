namespace DerRobert28.SharpTools.Types.Consumers {

	public class ByteConsumer: Consumer<byte> {

		public static ByteConsumer of(Consumer<byte>.Delegate function)
			=> new ByteConsumer(function);
		
		private ByteConsumer(Consumer<byte>.Delegate function): base(function) {}

	}

}
