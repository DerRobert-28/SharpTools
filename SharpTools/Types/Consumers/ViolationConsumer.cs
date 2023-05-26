namespace DerRobert28.SharpTools.Types.Consumers
{
	using DerRobert28.SharpTools.Helpers;

	public class ViolationConsumer: Consumer<Violation>
	{
		public static new ViolationConsumer of(Consumer<Violation> function) => new ViolationConsumer(function);
		
		private ViolationConsumer(Consumer<Violation> function): base(function) {}
	}
}
