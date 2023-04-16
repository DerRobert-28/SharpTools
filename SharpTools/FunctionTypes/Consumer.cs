namespace DerRobert28.SharpTools.FunctionTypes {

	public class Consumer<T> {

		public delegate void Delegate(T value);
		private readonly Delegate consumer;

		public static Consumer<T> of(Delegate consumer) => new Consumer<T>(consumer);

		public Consumer<T> accept() => this;
		public void accept(T value) => consumer.Invoke(value);

		protected Consumer(Delegate consumer) => this.consumer = consumer;
	
	}

}
