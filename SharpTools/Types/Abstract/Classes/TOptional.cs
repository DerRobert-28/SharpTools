namespace DerRobert28.SharpTools.Types.Abstract.Classes {

using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Interfaces;
using DerRobert28.SharpTools.Types.Functions;


public abstract class TOptional<C, T>: TAssertions, IOptional<C, T> {

	protected readonly bool hasValue;
	protected readonly T value;

	public bool isDefined() => hasValue;

	public bool isUndefined() => !hasValue;

	public T get() {
		assertHavingValue(this);
		return value;
	}

	public object map<R>(Function1<T, R> mapper) {
		assertMapperNotNull(mapper);
		return mapper.apply(value);
	}

	public C peek(IAcceptor<T> consumer) {
		assertConsumerNotNull(consumer);
		if(hasValue) {
			consumer.accept(value);
		}
		return Caster<C>.of(this);
	}

	protected TOptional()
		=> hasValue = false;

	protected TOptional(T value) {
		assertObjectNotNull(value);
		this.value = value;
		hasValue = true;
	}

}}
