namespace DerRobert28.SharpTools.Types.Abstract.Interfaces
{
	using DerRobert28.SharpTools.Types.Functions;

	public interface IMapper<T>
	{
		object map<R>(Function1<T, R> mapper);
	}
}
