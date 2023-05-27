namespace DerRobert28.SharpTools.Types.Functions {

using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;


public class Function3<T1, T2, T3, R>: TFunction<Function3<T1, T2, T3, R>, R> {

	private readonly Func<T1, T2, T3, R> function;

	public static Function3<T1, T2, T3, R> of(Func<T1, T2, T3, R> function)
		=> new Function3<T1, T2, T3, R>(function);

	public Function2<T2, T3, R> apply(T1 t1)
		=> Function2<T2, T3, R>.of((t2, t3) => function.Invoke(t1, t2, t3));

	public Function1<T3, R> apply(T1 t1, T2 t2)
		=> Function1<T3, R>.of(t3 => function.Invoke(t1, t2, t3));

	public R apply(T1 t1, T2 t2, T3 t3)
		=> function.Invoke(t1, t2, t3);

	public static implicit operator Function3<T1, T2, T3, R>(Func<T1, T2, T3, R> function)
		=> of(function);

	private Function3(Func<T1, T2, T3, R> function): base(3) {
		assertFunctionNotNull(function);
		this.function = function;
	}

}}
