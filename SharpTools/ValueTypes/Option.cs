namespace DerRobert28.SharpTools.ValueTypes {

	using FunctionTypes;

	public class Option<T> {

		//
		//	PRIVATE FIELDS:
		//

		private readonly bool hasValue;
		private readonly T value;
		
		//
		//	PUBLIC METHODS:
		//

		public bool isDefined() => hasValue;
		
		public T get() {
			if(!hasValue) {
				throw Violation.MissingGetValue;
			}
			return value;
		}
		
		public Option<T> peek(Consumer<T> consumer) {
			if(hasValue) {
				consumer.accept(value);
			}
			return this;
		}
	
		public static Option<T> none() => new Option<T>();
		
		public static Option<T> of(T value) => new Option<T>(value);
		
		public Option<R> map<R>(Function1<T, R> mapper) {
			if(mapper == null) {
				throw Violation.MissingMapper;
			}
			return new Option<R>(mapper.apply(value));
		}
		
		//
		//	PRIVATE CONSTRUCTORS:
		//

		private Option() => this.hasValue = false;
		private Option(T value) {
			this.value = value;
			this.hasValue = true;
		}

	}

}
