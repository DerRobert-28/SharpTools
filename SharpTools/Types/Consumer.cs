namespace DerRobert28.SharpTools.Types {

using DerRobert28.SharpTools.Types.Abstract.Classes;
using System;


public class Consumer<T>: TAcceptor<T> {
		
	public static Consumer<T> of(Action<T> function)
		=> new Consumer<T>(function);

	public static Consumer<T> of(Consumer<T> consumer)
		=> new Consumer<T>(consumer.function);

	public static implicit operator Action<T>(Consumer<T> consumer)
		=> consumer.function;

	public static implicit operator Consumer<T>(Action<T> function)
		=> of(new Action<T>(function));

	protected Consumer(Action<T> consumer): base(consumer) {}
	
}}
