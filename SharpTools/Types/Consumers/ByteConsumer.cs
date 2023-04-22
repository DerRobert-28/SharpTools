namespace DerRobert28.SharpTools.Types.Consumers {

	public class ByteConsumer: Consumer<byte> {

		public static ByteConsumer of(Delegate function)
			=> new ByteConsumer(function);
		
		private ByteConsumer(Delegate function): base(function) {}

	}

}
