namespace DerRobert28.SharpTools.Types {

using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;


public class Supplier<T>: TSupplier<Supplier<T>, T> {
		
	public static Supplier<T> of(Func<T> function)
		=> new Supplier<T>(function);

	public static Supplier<T> of(Supplier<T> supplier)
		=> new Supplier<T>(supplier.function);

	public static implicit operator Func<T>(Supplier<T> supplier)
		=> supplier.function;

	public static implicit operator Supplier<T>(Func<T> function)
		=> of(function);

	protected Supplier(Func<T> function):
		base(function) {}

}}
