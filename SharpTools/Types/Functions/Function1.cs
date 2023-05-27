namespace DerRobert28.SharpTools.Types.Functions {

using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;


public class Function1<T, R>: TFunction<Function1<T, R>, R> {

	private readonly Func<T, R> function;

	public static Function1<T, R> of(Func<T, R> function)
		=> new Function1<T, R>(function);

	public R apply(T value)
		=> function.Invoke(value);

	public static Function1<T, T> identity()
		=> Function1<T, T>.of(x => x);

	public static implicit operator Function1<T, R>(Func<T, R> function)
		=> of(function);

	private Function1(Func<T, R> function): base(1) {
		assertFunctionNotNull(function);
		this.function = function;
	}

}}
