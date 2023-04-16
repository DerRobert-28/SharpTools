namespace DerRobert28.SharpTools.FunctionTypes.Consumers {

	using System;

	public class ExceptionConsumer: Consumer<Exception> {

		public static ExceptionConsumer of(Consumer<Exception>.Delegate consumer)
			=> new ExceptionConsumer(consumer);
		
		private ExceptionConsumer(Consumer<Exception>.Delegate consumer): base(consumer) {}

	}

}
