using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;

namespace DerRobert28.SharpTools.Types.Functions {
	
	public class Function2<T1, T2, R>:
		TFunction<Function2<T1, T2, R>, R> {

		private readonly Func<T1, T2, R> function;

		public static Function2<T1, T2, R> of(Func<T1, T2, R> function)
			=> new Function2<T1, T2, R>(function);

		public Function1<T2, R> apply(T1 t1)
			=> Function1<T2, R>.of(t2
				=> function.Invoke(t1, t2));

		public R apply(T1 t1, T2 t2)
			=> function.Invoke(t1, t2);

		public static implicit operator Function2<T1, T2, R>
			(Func<T1, T2, R> function) => of(function);

		private Function2(Func<T1, T2, R> function):
			base(2) => this.function = function;

	}

}
