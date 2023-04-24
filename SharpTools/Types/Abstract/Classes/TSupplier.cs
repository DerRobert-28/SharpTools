using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Interfaces;
using System;

namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	public abstract class TSupplier<C, T>: ISupplier<C, T> {
		
		protected readonly Func<T> function;

		public T get()
			=> function.Invoke();

		public C peek(IAcceptor<T> consumer) {
			consumer.accept(get());
			return Caster<C>.of(this);
		}

		protected TSupplier(Func<T> function) => this.function = function;
	
	}

}
