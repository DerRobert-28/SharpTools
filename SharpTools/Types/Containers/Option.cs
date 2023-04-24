using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Classes;
using DerRobert28.SharpTools.Types.Functions;


namespace DerRobert28.SharpTools.Types.Containers {

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
