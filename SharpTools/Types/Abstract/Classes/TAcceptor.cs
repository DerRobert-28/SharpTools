namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	using Interfaces;

	public abstract class TAcceptor<T>: IAcceptor<TAcceptor<T>, T> {
		
		public delegate void Delegate(T value);
		protected readonly Delegate function;

		public TAcceptor<T> accept() => this;
		public void accept(T value) => function.Invoke(value);

		protected TAcceptor(Delegate function) => this.function = function;
	
	}

}
