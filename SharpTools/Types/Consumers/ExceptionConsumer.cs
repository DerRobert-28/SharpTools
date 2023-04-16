namespace DerRobert28.SharpTools.Types.Consumers {

	using System;

	public class ExceptionConsumer: Consumer<Exception> {

		public static ExceptionConsumer of(Consumer<Exception>.Delegate function)
			=> new ExceptionConsumer(function);
		
		private ExceptionConsumer(Consumer<Exception>.Delegate function): base(function) {}

	}

}
