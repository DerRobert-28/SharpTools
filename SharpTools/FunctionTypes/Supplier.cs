namespace DerRobert28.SharpTools.FunctionTypes {

	public class Supplier<T> {

		public delegate T Delegate();
		private readonly Delegate supplier;

		public static Supplier<T> of(Delegate supplier) => new Supplier<T>(supplier);

		public T get() => supplier.Invoke();

		public Supplier<T> peek(Consumer<T> consumer) {
			consumer.accept(get());
			return this;
		}

		protected Supplier(Delegate supplier) => this.supplier = supplier;
	
	}
}
