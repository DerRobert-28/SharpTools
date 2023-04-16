namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	using Functions;

	public interface IMapper<C, T, R> {

		C map(Function1<T, R> function);

	}

}
