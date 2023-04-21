namespace DerRobert28.SharpTools.Types.Functions {

	using Abstract.Classes;
	using System;
	
	public class Function2<T1, T2, R>:
		TFunction<Function2<T1, T2, R>> {

		//
		//	PRIVATE ELEMENTS:
		//

		public delegate R Delegate(T1 t1, T2 t2);
		private readonly Delegate function;

		//
		//	PUBLIC METHODS:
		//

		public static Function2<T1, T2, R> of(Delegate function)
			=> new Function2<T1, T2, R>(function);

		public override Function2<T1, T2, R> apply() => this;

		public Function1<T2, R> apply(T1 t1)
			=> Function1<T2, R>.of(t2
				=> function.Invoke(t1, t2));

		public R apply(T1 t1, T2 t2)
			=> function.Invoke(t1, t2);

		public static explicit operator Function2<T1, T2, R>
			(Func<T1, T2, R> function) => of(new Delegate(function));

		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Function2(Delegate function): base(2) => this.function = function;

	}

}
