using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;

namespace DerRobert28.SharpTools.Types.Functions {

	public class Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>:
		TFunction<Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>> {
	
		private readonly Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> function;
		
		public static Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> of
			(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> function)
			=> new Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(function);

		public override Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> apply()
			=> this;

		public Function8<T2, T3, T4, T5, T6, T7, T8, T9, R> apply(T1 t1)
			=> Function8<T2, T3, T4, T5, T6, T7, T8, T9, R>.of((t2, t3, t4, t5, t6, t7, t8, t9)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9));

		public Function7<T3, T4, T5, T6, T7, T8, T9, R> apply(T1 t1, T2 t2)
			=> Function7<T3, T4, T5, T6, T7, T8, T9, R>.of((t3, t4, t5, t6, t7, t8, t9)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9));

		public Function6<T4, T5, T6, T7, T8, T9, R> apply(T1 t1, T2 t2, T3 t3)
			=> Function6<T4, T5, T6, T7, T8, T9, R>.of((t4, t5, t6, t7, t8, t9)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9));

		public Function5<T5, T6, T7, T8, T9, R> apply(T1 t1, T2 t2, T3 t3, T4 t4)
			=> Function5<T5, T6, T7, T8, T9, R>.of((t5, t6, t7, t8, t9)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9));

		public Function4<T6, T7, T8, T9, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			=> Function4<T6, T7, T8, T9, R>.of((t6, t7, t8, t9)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9));

		public Function3<T7, T8, T9, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			=> Function3<T7, T8, T9, R>.of((t7, t8, t9)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9));

		public Function2<T8, T9, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			=> Function2<T8, T9, R>.of((t8, t9)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9));

		public Function1<T9, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			=> Function1<T9, R>.of((t9)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9));

		public R apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			=> function.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9);

		public static explicit operator Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>
			(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> function)
				=> of(function);

		private Function9(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> function):
			base(9) => this.function = function;

	}

}
