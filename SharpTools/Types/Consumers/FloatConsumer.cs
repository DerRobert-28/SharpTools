namespace DerRobert28.SharpTools.Types.Consumers {

	public class FloatConsumer: Consumer<float> {

		public static FloatConsumer of(Delegate function)
			=> new FloatConsumer(function);
		
		private FloatConsumer(Delegate function): base(function) {}

	}

}
