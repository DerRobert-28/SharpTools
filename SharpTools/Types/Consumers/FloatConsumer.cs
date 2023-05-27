namespace DerRobert28.SharpTools.Types.Consumers {


public class FloatConsumer: Consumer<float> {

	public static new FloatConsumer of(Consumer<float> function)
		=> new FloatConsumer(function);
		
	private FloatConsumer(Consumer<float> function): base(function) {}

}}
