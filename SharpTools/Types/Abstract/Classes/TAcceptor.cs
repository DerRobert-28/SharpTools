namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	using Interfaces;

	public abstract class TAcceptor<C, T>: IAcceptor<TAcceptor<C, T>, T> {
		
		public delegate void Delegate(T value);
		protected readonly Delegate function;

		public TAcceptor<C, T> accept() => this;
		public void accept(T value) => function.Invoke(value);

		protected TAcceptor(Delegate function) => this.function = function;
	
	}

}
