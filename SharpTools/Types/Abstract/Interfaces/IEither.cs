namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IEither<C, L, R>:
		ILeftValue<C, L>, IValue<C, R> {
	
		bool isLeft();
		bool isRight();

	}

}
