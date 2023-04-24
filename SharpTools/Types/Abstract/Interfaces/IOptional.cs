using System.Runtime.Remoting.Messaging;


namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IOptional<C, T>: IValue<C, T> {

		bool isDefined();

	}

}
