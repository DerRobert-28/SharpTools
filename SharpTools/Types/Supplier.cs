namespace DerRobert28.SharpTools.Types {

	using Abstract.Interfaces;

	public class Supplier<T>: IValue<Supplier<T>, T> {
		
		public delegate T Delegate();
		private readonly Delegate supplier;
		
		public static Supplier<T> of(Delegate supplier) => new Supplier<T>(supplier);

		public T get() => supplier.Invoke();

		public Supplier<T> peek(IAcceptor<Supplier<T>, T> consumer) {
			consumer.accept(get());
			return this;
		}

		protected Supplier(Delegate supplier) => this.supplier = supplier;
	
	}

}
