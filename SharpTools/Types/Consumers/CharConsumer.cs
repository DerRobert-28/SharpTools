namespace DerRobert28.SharpTools.Types.Consumers
{
	public class CharConsumer: Consumer<char>
	{
		public static new CharConsumer of(Consumer<char> function) => new CharConsumer(function);
		
		private CharConsumer(Consumer<char> function): base(function) {}
	}
}
