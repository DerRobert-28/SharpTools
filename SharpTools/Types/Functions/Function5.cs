namespace DerRobert28.SharpTools.Types.Functions {

	using Abstract.Classes;
	using System;

	public class Function5<T1, T2, T3, T4, T5, R>:
		TFunction<Function5<T1, T2, T3, T4, T5, R>> {
	
		//
		//	PRIVATE ELEMENTS:
		//

		public delegate R Delegate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
		private readonly Delegate function;
		
		//
		//	PUBLIC METHODS:
		//
		
		public static Function5<T1, T2, T3, T4, T5, R> of(Delegate function)
			=> new Function5<T1, T2, T3, T4, T5, R>(function);

		public override Function5<T1, T2, T3, T4, T5, R> apply() => this;

		public Function4<T2, T3, T4, T5, R> apply(T1 t1)
			=> Function4<T2, T3, T4, T5, R>.of((t2, t3, t4, t5)
				=> function.Invoke(t1, t2, t3, t4, t5));

		public Function3<T3, T4, T5, R> apply(T1 t1, T2 t2)
			=> Function3<T3, T4, T5, R>.of((t3, t4, t5)
				=> function.Invoke(t1, t2, t3, t4, t5));

		public Function2<T4, T5, R> apply(T1 t1, T2 t2, T3 t3)
			=> Function2<T4, T5, R>.of((t4, t5)
				=> function.Invoke(t1, t2, t3, t4, t5));

		public Function1<T5, R> apply(T1 t1, T2 t2, T3 t3, T4 t4)
			=> Function1<T5, R>.of(t5
				=> function.Invoke(t1, t2, t3, t4, t5));

		public R apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			=> function.Invoke(t1, t2, t3, t4, t5);

		public static explicit operator Function5<T1, T2, T3, T4, T5, R>
			(Func<T1, T2, T3, T4, T5, R> function) => of(new Delegate(function));

		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Function5(Delegate function): base(5) => this.function = function;

	}

}
