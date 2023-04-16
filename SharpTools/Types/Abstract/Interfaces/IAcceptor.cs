namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IAcceptor<C, T> {

		C accept();

		void accept(T value);

	}

}
