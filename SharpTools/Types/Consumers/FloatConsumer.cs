namespace DerRobert28.SharpTools.Types.Consumers {

	public class FloatConsumer: Consumer<float> {

		public static FloatConsumer of(Consumer<float>.Delegate function)
			=> new FloatConsumer(function);
		
		private FloatConsumer(Consumer<float>.Delegate function): base(function) {}

	}

}
