namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface ILeftValue<C, T>:
		ILeftGetter<T>, ILeftMapper<T>, ILeftPeeker<C, T> {
	}

}
