namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	using Containers;
	using Interfaces;

	public abstract class TEither<L, R>: IEither<L, R> {

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

		public TEither<L, R> peek(IAcceptor<TEither<L, R>, R> function) {
			if(isRight()) {
				function.accept(rightValue);
			}
			return this;
		}

		public TEither<L, R> peekLeft(IAcceptor<TEither<L, R>, L> function) {
			if(isLeft()) {
				function.accept(leftValue);
			}
			return this;
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
