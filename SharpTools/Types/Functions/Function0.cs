﻿namespace DerRobert28.SharpTools.Types.Functions {

	using Abstract.Classes;
	using System;

	public class Function0<R>: TFunction<R> {
	
		//
		//	PRIVATE ELEMENTS:
		//

		public delegate R Delegate();
		private readonly Delegate function;
		
		//
		//	PUBLIC METHODS:
		//

		public static Function0<R> of(Delegate function) => new Function0<R>(function);

		//public override IFunction

		public override R apply() => function.Invoke();

		public static explicit operator Function0<R>
			(Func<R> function) => of(new Delegate(function));
		
		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Function0(Delegate function): base(0) => this.function = function;

	}

}