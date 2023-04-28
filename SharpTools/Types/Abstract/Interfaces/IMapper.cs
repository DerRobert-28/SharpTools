using DerRobert28.SharpTools.Types.Functions;

namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IMapper<T> {

		object map<R>(Function1<T, R> mapper);
	
	}

}
