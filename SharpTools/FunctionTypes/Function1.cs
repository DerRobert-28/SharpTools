namespace DerRobert28.SharpTools.FunctionTypes {

	public class Function1<T, R> {

		public delegate R Delegate(T value);
		private readonly Delegate function;

		public static Function1<T, R> of(Delegate function) => new Function1<T, R>(function);

		public Function1<T, R> apply() => this;
		public R apply(T value) => function.Invoke(value);

		private Function1(Delegate function) => this.function = function;

	}

}
