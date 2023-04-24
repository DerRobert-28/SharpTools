using DerRobert28.SharpTools.Types.Abstract.Classes;

namespace DerRobert28.SharpTools.Types.Containers {

	public class Either<L, R>: TEither<Either<L, R>, L, R> {
		
		public static Either<L, R> left(L value)
			=> new Either<L, R>(Projection.Left, value);

		public static Either<L, R> right(R value)
			=> new Either<L, R>(Projection.Right, value);

		private Either(Projection projection, object value):
			base(projection, value) {}

	}

}
