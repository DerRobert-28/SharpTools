using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;

namespace DerRobert28.SharpTools.Types.Functions {

	public class Function7<T1, T2, T3, T4, T5, T6, T7, R>:
		TFunction<Function7<T1, T2, T3, T4, T5, T6, T7, R>, R> {
	
		private readonly Func<T1, T2, T3, T4, T5, T6, T7, R> function;
		
		public static Func<T1, T2, T3, T4, T5, T6, T7, R> of(Func<T1, T2, T3, T4, T5, T6, T7, R> function)
			=> new Func<T1, T2, T3, T4, T5, T6, T7, R>(function);

		public Function6<T2, T3, T4, T5, T6, T7, R> apply(T1 t1)
			=> Function6<T2, T3, T4, T5, T6, T7, R>.of((t2, t3, t4, t5, t6, t7)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7));

		public Function5<T3, T4, T5, T6, T7, R> apply(T1 t1, T2 t2)
			=> Function5<T3, T4, T5, T6, T7, R>.of((t3, t4, t5, t6, t7)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7));

		public Function4<T4, T5, T6, T7, R> apply(T1 t1, T2 t2, T3 t3)
			=> Function4<T4, T5, T6, T7, R>.of((t4, t5, t6, t7)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7));

		public Function3<T5, T6, T7, R> apply(T1 t1, T2 t2, T3 t3, T4 t4)
			=> Function3<T5, T6, T7, R>.of((t5, t6, t7)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7));

		public Function2<T6, T7, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			=> Function2<T6, T7, R>.of((t6, t7)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7));

		public Function1<T7, R> apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			=> Function1<T7, R>.of((t7)
				=> function.Invoke(t1, t2, t3, t4, t5, t6, t7));

		public R apply(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			=> function.Invoke(t1, t2, t3, t4, t5, t6, t7);

		public static implicit operator Function7<T1, T2, T3, T4, T5, T6, T7, R>
			(Func<T1, T2, T3, T4, T5, T6, T7, R> function) => of(function);

		private Function7(Func<T1, T2, T3, T4, T5, T6, T7, R> function):
			base(7) => this.function = function;

	}

}
