namespace SharpTools.ValueTypes {

	using FunctionTypes;
	
	public class Either<L, R> {
		
		//
		//	PRIVATE FIELDS:
		//

		private enum Projection {
			Left,
			Right
		}

		private readonly Projection projection;
		private readonly L leftValue;
		private readonly R rightValue;

		//
		//	LEFT METHODS:
		//

		public static Either<L, R> left(L value) => new Either<L, R>(Projection.Left, value);
		
		public bool isLeft() => isLeft(projection);
		
		public L getLeft() {
			if(isRight()) {
				throw Violation.MissingGetLeftValue;
			}
			return leftValue;
		}

		public Either<L, R> peekLeft(Consumer<L> consumer) {
			if(isLeft()) {
				consumer.accept(leftValue);
			}
			return this;
		}

		//
		//	RIGHT METHODS:
		//

		public static Either<L, R> right(R value) => new Either<L, R>(Projection.Right, value);
		
		public bool isRight() => isRight(projection);
		
		public R get() {
			if(isLeft()) {
				throw Violation.MissingGetValue;
			}
			return rightValue;
		}

		public Either<L, R> peek(Consumer<R> consumer) {
			if(isRight()) {
				consumer.accept(rightValue);
			}
			return this;
		}

		//
		//	PRIVATE METHODS & CONSTRUCTORS:
		//

		private bool isLeft(Projection projection) => projection == Projection.Left;

		private bool isRight(Projection projection) => projection == Projection.Right;

		private Either(Projection projection, L value) {
			if(isLeft(projection)) {
				leftValue = value;
				this.projection = projection;
			}
		}
		private Either(Projection projection, R value) {
			if(isRight(projection)) {
				rightValue = value;
				this.projection = projection;
			}
		}

	}

}
