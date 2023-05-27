namespace DerRobert28.SharpTools.Types.Abstract.Interfaces {

using DerRobert28.SharpTools.Types.Functions;


public interface ILeftMapper<T> {

	object mapLeft<R>(Function1<T, R> mapper);

}}
