namespace DerRobert28.SharpTools.Types.Containers {

	using Abstract.Classes;
	using Abstract.Interfaces;
	using Functions;
	using System;

	public class Option<T>: TOptional<Option<T>, T> {
	
		public static Option<T> none() => new Option<T>();
		
		public static Option<T> of(T value) => new Option<T>(value);
		
		public Option<R> map<R>(Function1<T, R> mapper) {
			if(mapper == null) {
				throw Violation.MissingMapper;
			}
			return new Option<R>(mapper.apply(value));
		}

		private Option(): base() {}
		private Option(T value): base(value) {}

	}

}
