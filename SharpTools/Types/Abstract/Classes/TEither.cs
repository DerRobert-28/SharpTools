using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Interfaces;

namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	public abstract class TEither<C, L, R>: IEither<C, L, R> {

		protected enum Projection {
			Left,
			Right
		}

		private readonly Projection projection;
		private readonly L leftValue;
		private readonly R rightValue;

		public bool isLeft() => isLeft(projection);
		public bool isRight() => isRight(projection);
		
		public R get() {
			if(isLeft()) {
				throw Violation.MissingGetValue;
			}
			return rightValue;
		}

		public L getLeft() {
			if(isRight()) {
				throw Violation.MissingGetLeftValue;
			}
			return leftValue;
		}

		public C peek(IAcceptor<R> function) {
			if(isRight()) {
				function.accept(rightValue);
			}
			return Caster<C>.of(this);
		}

		public C peekLeft(IAcceptor<L> function) {
			if(isLeft()) {
				function.accept(leftValue);
			}
			return Caster<C>.of(this);
		}

		private bool isLeft(Projection projection) => projection == Projection.Left;
		private bool isRight(Projection projection) => projection == Projection.Right;

		protected TEither(Projection projection, object value) {
			if(isLeft(projection)) {
				leftValue = (L)value;
				this.projection = projection;
			}
			if(isRight(projection)) {
				rightValue = (R)value;
				this.projection = projection;
			}
		}

	}

}
