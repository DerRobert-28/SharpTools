using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Classes;
using DerRobert28.SharpTools.Types.Functions;

namespace DerRobert28.SharpTools.Types.Containers {

	public class Either<L1, R1>: TEither<Either<L1, R1>, L1, R1> {
		
		public static Either<L1, R1> left(L1 value)
			=> new Either<L1, R1>(Projection.Left, value);
		
		public Either<L2, R1> mapLeft<L2>(Function1<L1, L2> mapper)
			=> Caster<Either<L2, R1>>.of(base.mapLeft(mapper));
		
		public static Either<L1, R1> right(R1 value)
			=> new Either<L1, R1>(Projection.Right, value);

		public Either<L1, R2> map<R2>(Function1<R1, R2> mapper)
			=> Caster<Either<L1, R2>>.of(base.map(mapper));

		private Either(Projection projection, object value):
			base(projection, value) {}

	}

}
