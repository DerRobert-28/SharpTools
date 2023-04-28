using DerRobert28.SharpTools.Types.Functions;

namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface ILeftMapper<T> {
	
		object mapLeft<R>(Function1<T, R> mapper);

	}

}
