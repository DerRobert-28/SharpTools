namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface ILeftPeeker<C, T> {

		C peekLeft(IAcceptor<T> function);

	}

}
