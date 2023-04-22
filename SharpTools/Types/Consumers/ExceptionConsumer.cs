namespace DerRobert28.SharpTools.Types.Consumers {

	using System;

	public class ExceptionConsumer: Consumer<Exception> {

		public static ExceptionConsumer of(Delegate function)
			=> new ExceptionConsumer(function);
		
		private ExceptionConsumer(Delegate function): base(function) {}

	}

}
