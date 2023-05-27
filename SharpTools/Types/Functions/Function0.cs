namespace DerRobert28.SharpTools.Types.Functions {

using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;


public class Function0<R>: TFunction<Function0<R>, R> {

	private readonly Func<R> function;

	public static Function0<R> of(Func<R> function)
		=> new Function0<R>(function);

	public new R apply()
		=> function.Invoke();

	public static implicit operator Function0<R>(Func<R> function)
		=> of(function);

	private Function0(Func<R> function): base(0) {
		assertFunctionNotNull(function);
		this.function = function;
	}

}}
