using DerRobert28.SharpTools.Types.Abstract.Classes;


namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IAcceptor<T> {

		IAcceptor<T> accept();

		void accept(T value);

	}

}
