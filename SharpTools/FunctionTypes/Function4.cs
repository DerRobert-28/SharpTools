namespace SharpTools.FunctionTypes {

	public class Function4<T1, T2, T3, T4, R> {

		public delegate R Delegate(T1 t1, T2 t2, T3 t3, T4 t4);
		private readonly Delegate function;

		public static Function4<T1, T2, T3, T4, R> of(Delegate function)
			=> new Function4<T1, T2, T3, T4, R>(function);

		public Function4<T1, T2, T3, T4, R> apply() => this;
		public Function3<T2, T3, T4, R> apply(T1 t1)
			=> Function3<T2, T3, T4, R>.of((t2, t3, t4) => function.Invoke(t1, t2, t3, t4));
		public Function2<T3, T4, R> apply(T1 t1, T2 t2)
			=> Function2<T3, T4, R>.of((t3, t4) => function.Invoke(t1, t2, t3, t4));
		public Function1<T4, R> apply(T1 t1, T2 t2, T3 t3)
			=> Function1<T4, R>.of(t4 => function.Invoke(t1, t2, t3, t4));
		public R apply(T1 t1, T2 t2, T3 t3, T4 t4) => function.Invoke(t1, t2, t3, t4);

		private Function4(Delegate function) => this.function = function;

	}

}
