using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Interfaces;
using DerRobert28.SharpTools.Types.Containers;
using DerRobert28.SharpTools.Types.Functions;

namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	public abstract class TEither<C, L1, R1>: IEither<C, L1, R1> {

		protected enum Projection {
			Left,
			Right
		}

		private readonly Projection projection;
		private readonly L1 leftValue;
		private readonly R1 rightValue;

		public bool isLeft() => isLeft(projection);
		public bool isRight() => isRight(projection);
		
		public R1 get() {
			if(isLeft()) {
				throw Violation.MissingGetValue;
			}
			return rightValue;
		}

		public L1 getLeft() {
			if(isRight()) {
				throw Violation.MissingGetLeftValue;
			}
			return leftValue;
		}
		
		public object map<R2>(Function1<R1, R2> mapper) {
			if(mapper == null) {
				throw Violation.MissingMapper;
			}
			if(isRight()) {
				return mapper.apply(get());
			} else {
				return getLeft();
			}
		}

		public object mapLeft<L2>(Function1<L1, L2> mapper) {
			if(mapper == null) {
				throw Violation.MissingMapper;
			}
			if(isLeft()) {
				return mapper.apply(getLeft());
			} else {
				return get();
			}
		}
		

		public C peek(IAcceptor<R1> function) {
			if(isRight()) {
				function.accept(rightValue);
			}
			return Caster<C>.of(this);
		}

		public C peekLeft(IAcceptor<L1> function) {
			if(isLeft()) {
				function.accept(leftValue);
			}
			return Caster<C>.of(this);
		}

		private bool isLeft(Projection projection) => projection == Projection.Left;
		private bool isRight(Projection projection) => projection == Projection.Right;

		protected TEither(Projection projection, object value) {
			if(isLeft(projection)) {
				leftValue = (L1)value;
				this.projection = projection;
			}
			if(isRight(projection)) {
				rightValue = (R1)value;
				this.projection = projection;
			}
		}

	}

}
