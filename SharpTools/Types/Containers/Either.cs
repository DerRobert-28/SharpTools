namespace DerRobert28.SharpTools.Types.Containers {
	
	using Abstract.Classes;
	using Abstract.Interfaces;
	using Types;
	
	public class Either<L, R>: TEither<L, R> {
		
		public static Either<L, R> left(L value) => new Either<L, R>(Projection.Left, value);

		public static Either<L, R> right(R value) => new Either<L, R>(Projection.Right, value);

		public Either<L, R> peek(TAcceptor<R> function)
			=> (Either<L, R>) peek((IAcceptor<TEither<L, R>, R>) function);

		public Either<L, R> peekLeft(TAcceptor<L> function)
			=> (Either<L, R>) peekLeft((IAcceptor<TEither<L, R>, L>) function);


		private Either(Projection projection, object value): base(projection, value) {}

	}

}
