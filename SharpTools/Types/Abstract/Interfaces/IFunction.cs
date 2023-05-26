namespace DerRobert28.SharpTools.Types.Abstract.Interfaces
{
	public interface IFunction<C, R>
	{
		int getArity();

		C apply();
	}
}
