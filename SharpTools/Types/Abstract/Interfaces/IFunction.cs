namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IFunction<R> {

		int getArity();

		R apply();

	}

}
