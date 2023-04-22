namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	using Containers;
	using Functions;
	using Interfaces;
	using System;

	public abstract class TOptional<C, T>: IOptional<C, T> {

		protected readonly bool hasValue;
		protected readonly T value;

		public bool isDefined() => hasValue;

		public T get() {
			if(!hasValue) {
				throw Violation.MissingGetValue;
			}
			return value;
		}

		public C peek(IAcceptor<T> consumer) {
			if(hasValue) {
				consumer.accept(value);
			}
			return (C) (object) this;
		}

		protected TOptional() => hasValue = false;

		protected TOptional(T value) {
			this.value = value;
			this.hasValue = true;
		}

	}

}
