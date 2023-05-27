namespace DerRobert28.SharpTools.Types.Consumers {


public class ObjectConsumer: Consumer<object> {

	public static new ObjectConsumer of(Consumer<object> function)
		=> new ObjectConsumer(function);
		
	private ObjectConsumer(Consumer<object> function): base(function) {}

}}
