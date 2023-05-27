namespace DerRobert28.SharpTools.Types.Containers {

using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Classes;
using DerRobert28.SharpTools.Types.Functions;


public class Option<T>: TOptional<Option<T>, T> {

	public static Option<T> none() => new Option<T>();

	public static Option<T> of(T value) => new Option<T>(value);

	public new Option<R> map<R>(Function1<T, R> mapper) => Caster<Option<R>>.of(base.map(mapper));

	private Option(): base() {}

	private Option(T value): base(value) {}

}}
