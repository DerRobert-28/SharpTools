namespace DerRobert28.SharpTools.FunctionTypes.Functions {

	public class Function3<T1, T2, T3, R> {

		public delegate R Delegate(T1 t1, T2 t2, T3 t3);
		private readonly Delegate function;

		public static Function3<T1, T2, T3, R> of(Delegate function)
			=> new Function3<T1, T2, T3, R>(function);

		public Function3<T1, T2, T3, R> apply() => this;

		public Function2<T2, T3, R> apply(T1 t1)
			=> Function2<T2, T3, R>.of((t2, t3)
				=> function.Invoke(t1, t2, t3));

		public Function1<T3, R> apply(T1 t1, T2 t2)
			=> Function1<T3, R>.of(t3
				=> function.Invoke(t1, t2, t3));

		public R apply(T1 t1, T2 t2, T3 t3) => function.Invoke(t1, t2, t3);

		private Function3(Delegate function) => this.function = function;

	}

}
