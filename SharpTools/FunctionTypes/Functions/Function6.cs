namespace DerRobert28.SharpTools.FunctionTypes.Functions {

	using System;

	public class Function6<T1, T2, T3, T4, T5, T6, R>: Function {
	
		//
		//	PRIVATE ELEMENTS:
		//

		public delegate R Delegate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6);
		private readonly Delegate function;
		
		//
		//	PUBLIC METHODS:
		//
		
		public static Function6<T1, T2, T3, T4, T5, T6, R> of(Delegate function)
			=> new Function6<T1, T2, T3, T4, T5, T6, R>(function);

		public Function6<T1, T2, T3, T4, T5, T6, R> apply() => this;

		public Function5<T2, T3, T4, T5, T6, R> apply(T1 t1)
			=> Function5<T2, T3, T4, T5, T6, R>.of((t2, t3, t4, t5, t6)
				=> function.Invoke(t1, t2, t3, t4, t5, t6));

		public Function4<T3, T4, T5, T6, R> apply(T1 t1, T2 t2)
			=> Function4<T3, T4, T5, T6, R>.of((t3, t4, t5, t6)
				=> function.Invoke(t1, t2, t3, t4, t5, t6));

		public Function3<T4, T5, T6, R> apply(T1 t1, T2 t2, T3 t3)
			=> Function3<T4, T5, T6, R>.of((t4, t5, t6)
				=> function.Invoke(t1, t2, t3, t4, t5, t6));

		public Function2<T5, T6, R> apply(T1 t1, T2 t2, T3 t3, T4 t4)
			=> Function2<T5, T6, R>.of((t5, t6)
				=> function.Invoke(t1, t2, t3, t4, t5, t6));

		public Function1<T6, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			=> Function1<T6, R>.of((t6)
				=> function.Invoke(t1, t2, t3, t4, t5, t6));

		public R apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			=> function.Invoke(t1, t2, t3, t4, t5, t6);

		public static explicit operator Function6<T1, T2, T3, T4, T5, T6, R>
			(Func<T1, T2, T3, T4, T5, T6, R> function) => of(new Delegate(function));

		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Function6(Delegate function): base(6) => this.function = function;

	}

}
