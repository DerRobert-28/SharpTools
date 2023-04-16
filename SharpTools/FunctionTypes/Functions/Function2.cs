namespace DerRobert28.SharpTools.FunctionTypes.Functions {

	public class Function2<T1, T2, R> {

		public delegate R Delegate(T1 t1, T2 t2);
		private readonly Delegate function;

		public static Function2<T1, T2, R> of(Delegate function)
			=> new Function2<T1, T2, R>(function);

		public Function2<T1, T2, R> apply() => this;

		public Function1<T2, R> apply(T1 t1)
			=> Function1<T2, R>.of(t2
				=> function.Invoke(t1, t2));

		public R apply(T1 t1, T2 t2)
			=> function.Invoke(t1, t2);

		private Function2(Delegate function) => this.function = function;

	}

}
