namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IPeeker<C, T> {

		C peek(IAcceptor<C, T> function);

	}

}
