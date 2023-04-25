using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Containers;
using DerRobert28.SharpTools.Types.Functions;
using System.Runtime.Remoting.Messaging;


namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IOptional<C, T>: IValue<C, T> {

		bool isDefined();

	}

}
