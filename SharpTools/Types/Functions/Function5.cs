using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;

namespace DerRobert28.SharpTools.Types.Functions {

	public class Function5<T1, T2, T3, T4, T5, R>:
		TFunction<Function5<T1, T2, T3, T4, T5, R>, R> {
	
		private readonly Func<T1, T2, T3, T4, T5, R> function;
		
		public static Function5<T1, T2, T3, T4, T5, R> of(Func<T1, T2, T3, T4, T5, R> function)
			=> new Function5<T1, T2, T3, T4, T5, R>(function);

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

		public static implicit operator Function5<T1, T2, T3, T4, T5, R>
			(Func<T1, T2, T3, T4, T5, R> function) => of(function);

		private Function5(Func<T1, T2, T3, T4, T5, R> function):
			base(5) => this.function = function;

	}

}
