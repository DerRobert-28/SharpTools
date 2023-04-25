using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Interfaces;
using DerRobert28.SharpTools.Types.Containers;
using DerRobert28.SharpTools.Types.Functions;
using System;

namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	public abstract class TOptional<C, T>: IOptional<C, T> {

		protected readonly bool hasValue;
		protected readonly T value;

		public bool isDefined()
			=> hasValue;

		public T get() {
			if(!hasValue) {
				throw Violation.MissingGetValue;
			}
			return value;
		}

		public object map<R>(Function1<T, R> mapper) {
			if(mapper == null) {
				throw Violation.MissingMapper;
			}
			return mapper.apply(value);
		}

		public C peek(IAcceptor<T> consumer) {
			if(hasValue) {
				consumer.accept(value);
			}
			return Caster<C>.of(this);
		}

		protected TOptional() => hasValue = false;

		protected TOptional(T value) {
			this.value = value;
			this.hasValue = true;
		}

	}

}
