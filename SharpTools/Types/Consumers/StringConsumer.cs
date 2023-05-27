namespace DerRobert28.SharpTools.Types.Consumers {


public class StringConsumer: Consumer<string> {

	public static new StringConsumer of(Consumer<string> function)
		=> new StringConsumer(function);
		
	private StringConsumer(Consumer<string> function): base(function) {}

}}
