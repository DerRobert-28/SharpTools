namespace DerRobert28.SharpTools.Types.Functions {

	using System;

	public class Function3<T1, T2, T3, R>: TFunction {

		//
		//	PRIVATE ELEMENTS:
		//

		public delegate R Delegate(T1 t1, T2 t2, T3 t3);
		private readonly Delegate function;
		
		//
		//	PUBLIC METHODS:
		//

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

		public static explicit operator Function3<T1, T2, T3, R>
			(Func<T1, T2, T3, R> function) => of(new Delegate(function));

		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Function3(Delegate function): base(3) => this.function = function;

	}

}
