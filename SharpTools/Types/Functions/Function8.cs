namespace DerRobert28.SharpTools.Types.Functions {

	using Abstract.Classes;
	using System;

	public class Function8<T1, T2, T3, T4, T5, T6, T7, T8, R>:
		TFunction<Function8<T1, T2, T3, T4, T5, T6, T7, T8, R>> {
	
		//
		//	PRIVATE ELEMENTS:
		//

		public delegate R Delegate(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8);
		private readonly Delegate function;
		
		//
		//	PUBLIC METHODS:
		//
		

		public static Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> of(Delegate function)
			=> new Function8<T1, T2, T3, T4, T5, T6, T7, T8, R>(function);

		public override Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> apply() => this;

		public Function7<T2, T3, T4, T5, T6, T7, T8, R> apply(T1 t1)
			=> Function7<T2, T3, T4, T5, T6, T7, T8, R>.of((t2, t3, t4, t5, t6, t7, t8)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8));

		public Function6<T3, T4, T5, T6, T7, T8, R> apply(T1 t1, T2 t2)
			=> Function6<T3, T4, T5, T6, T7, T8, R>.of((t3, t4, t5, t6, t7, t8)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8));

		public Function5<T4, T5, T6, T7, T8, R> apply(T1 t1, T2 t2, T3 t3)
			=> Function5<T4, T5, T6, T7, T8, R>.of((t4, t5, t6, t7, t8)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8));

		public Function4<T5, T6, T7, T8, R> apply(T1 t1, T2 t2, T3 t3, T4 t4)
			=> Function4<T5, T6, T7, T8, R>.of((t5, t6, t7, t8)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8));

		public Function3<T6, T7, T8, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			=> Function3<T6, T7, T8, R>.of((t6, t7, t8)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8));

		public Function2<T7, T8, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			=> Function2<T7, T8, R>.of((t7, t8)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8));

		public Function1<T8, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			=> Function1<T8, R>.of((t8)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8));

		public R apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8);

		public static explicit operator Function8<T1, T2, T3, T4, T5, T6, T7, T8, R>
			(Func<T1, T2, T3, T4, T5, T6, T7, T8, R> function) => of(new Delegate(function));

		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Function8(Delegate function): base(8) => this.function = function;

	}

}
