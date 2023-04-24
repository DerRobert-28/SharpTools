using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;

namespace DerRobert28.SharpTools.Types.Functions {

	public class Function1<T, R>: TFunction<Function1<T, R>> {

		private readonly Func<T, R> function;

		public static Function1<T, R> of(Func<T, R> function)
			=> new Function1<T, R>(function);

		public override Function1<T, R> apply()
			=> this;

		public R apply(T value)
			=> function.Invoke(value);

		public static implicit operator Function1<T, R>
			(Func<T, R> function) => of(function);

		private Function1(Func<T, R> function):
			base(1) => this.function = function;

	}

}
