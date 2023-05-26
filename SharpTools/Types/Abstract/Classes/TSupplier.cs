namespace DerRobert28.SharpTools.Types.Abstract.Classes
{
	using DerRobert28.SharpTools.Helpers;
	using DerRobert28.SharpTools.Types.Abstract.Interfaces;
	using System;

	public abstract class TSupplier<C, T>: TAssertions, ISupplier<C, T>
	{
		protected readonly Func<T> function;

		public T get() => function.Invoke();

		public C peek(IAcceptor<T> consumer)
		{
			assertConsumerNotNull(consumer);

			consumer.accept(get());
			return Caster<C>.of(this);
		}

		protected TSupplier(Func<T> function) => this.function = function;
	}
}
