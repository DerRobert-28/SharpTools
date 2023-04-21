﻿namespace DerRobert28.SharpTools.Types.Functions {

	using Abstract.Classes;
	using System;

	public class Function4<T1, T2, T3, T4, R>:
		TFunction<Function4<T1, T2, T3, T4, R>> {
	
		//
		//	PRIVATE ELEMENTS:
		//

		public delegate R Delegate(T1 t1, T2 t2, T3 t3, T4 t4);
		private readonly Delegate function;
		
		//
		//	PUBLIC METHODS:
		//
		
		public static Function4<T1, T2, T3, T4, R> of(Delegate function)
			=> new Function4<T1, T2, T3, T4, R>(function);

		public override Function4<T1, T2, T3, T4, R> apply() => this;

		public Function3<T2, T3, T4, R> apply(T1 t1)
			=> Function3<T2, T3, T4, R>.of((t2, t3, t4)
				=> function.Invoke(t1, t2, t3, t4));

		public Function2<T3, T4, R> apply(T1 t1, T2 t2)
			=> Function2<T3, T4, R>.of((t3, t4)
				=> function.Invoke(t1, t2, t3, t4));

		public Function1<T4, R> apply(T1 t1, T2 t2, T3 t3)
			=> Function1<T4, R>.of(t4
				=> function.Invoke(t1, t2, t3, t4));

		public R apply(T1 t1, T2 t2, T3 t3, T4 t4)
			=> function.Invoke(t1, t2, t3, t4);
		
		public static explicit operator Function4<T1, T2, T3, T4, R>
			(Func<T1, T2, T3, T4, R> function) => of(new Delegate(function));

		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Function4(Delegate function): base(4) => this.function = function;

	}

}