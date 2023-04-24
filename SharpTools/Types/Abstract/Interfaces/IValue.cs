namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

	public interface IValue<C, T>:
		IGetter<T>, IMapper, IPeeker<C, T> {
	}

}
