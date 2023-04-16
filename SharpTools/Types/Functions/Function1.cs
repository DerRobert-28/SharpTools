namespace DerRobert28.SharpTools.Types.Functions {

	using System;

	public class Function1<T, R>: TFunction {

		//
		//	PRIVATE ELEMENTS:
		//

		public delegate R Delegate(T value);
		private readonly Delegate function;

		//
		//	PUBLIC METHODS:
		//

		public static Function1<T, R> of(Delegate function) => new Function1<T, R>(function);

		public Function1<T, R> apply() => this;

		public R apply(T value) => function.Invoke(value);

		public static explicit operator Function1<T, R>
			(Func<T, R> function) => of(new Delegate(function));

		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Function1(Delegate function): base(1) => this.function = function;

	}

}
