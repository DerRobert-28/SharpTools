namespace SharpTools.FunctionTypes {

	public class Function0<R> {

		public delegate R Delegate();
		private readonly Delegate function;

		public static Function0<R> of(Delegate function) => new Function0<R>(function);

		public R apply() => function.Invoke();

		private Function0(Delegate function) => this.function = function;

	}

}
