namespace DerRobert28.SharpTools.Types.Abstract.Classes {

using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Interfaces;
using DerRobert28.SharpTools.Types.Functions;


public abstract class TEither<C, L1, R1>: TAssertions, IEither<C, L1, R1> {

	protected enum Projection {
		LEFT,
		RIGHT
	}

	private readonly Projection projection;
	private readonly L1 leftValue;
	private readonly R1 rightValue;

	public bool isLeft() => isLeft(projection);

	public bool isRight() => isRight(projection);

	public R1 get() {
		assertProjectionIsRight(this);
		return rightValue;
	}

	public L1 getLeft() {
		assertProjectionIsLeft(this);
		return leftValue;
	}
	
	public object map<R2>(Function1<R1, R2> mapper) {
		assertMapperNotNull(mapper);
		if(isRight()) {
			return mapper.apply(get());
		}
		return getLeft();
	}

	public object mapLeft<L2>(Function1<L1, L2> mapper) {
		assertMapperNotNull(mapper);
		if(isLeft()) {
			return mapper.apply(getLeft());
		}
		return get();
	}
	

	public C peek(IAcceptor<R1> function) {
		assertConsumerNotNull(function);
		if(isRight()) {
			function.accept(rightValue);
		}
		return Caster<C>.of(this);
	}

	public C peekLeft(IAcceptor<L1> function) {
		assertConsumerNotNull(function);
		if(isLeft()) {
			function.accept(leftValue);
		}
		return Caster<C>.of(this);
	}

	private bool isLeft(Projection projection) => projection.Equals(Projection.LEFT);

	private bool isRight(Projection projection) => projection.Equals(Projection.RIGHT);

	protected TEither(Projection projection, object value) {
		if(isLeft(projection)) {
			leftValue = Caster<L1>.of(value);
		} else {
			rightValue = Caster<R1>.of(value);
		}
		this.projection = projection;
	}

}}
