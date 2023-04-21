namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	using Containers;
	using Interfaces;
	using System;

	public abstract class TOptional<C, T>: IOptional<TOptional<C, T>, T> {

		protected readonly bool hasValue;
		protected readonly T value;

		public bool isDefined() => hasValue;

		public T get() {
			if(!hasValue) {
				throw Violation.MissingGetValue;
			}
			return value;
		}

		public TOptional<C, T> peek(IAcceptor<TOptional<C, T>, T> consumer) {
			if(hasValue) {
				consumer.accept(value);
			}
			return this;
		}

		protected TOptional() => hasValue = false;

		protected TOptional(T value) {
			this.value = value;
			this.hasValue = true;
		}

	}

}
