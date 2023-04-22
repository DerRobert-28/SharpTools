namespace DerRobert28.SharpTools.Types {

	using Abstract.Classes;
	using DerRobert28.SharpTools.Types.Functions;
	using System;

	public class Consumer<T>: TAcceptor<T> {
		
		public static Consumer<T> of(Delegate consumer) => new Consumer<T>(consumer);

		public static explicit operator Consumer<T>(Action<T> function)
			=> of(new Delegate(function));

		protected Consumer(Delegate consumer): base(consumer) {}
	
	}

}
