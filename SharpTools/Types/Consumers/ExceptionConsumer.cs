namespace DerRobert28.SharpTools.Types.Consumers {

using System;


public class ExceptionConsumer: Consumer<Exception> {

	public static new ExceptionConsumer of(Consumer<Exception> function)
		=> new ExceptionConsumer(function);
		
	private ExceptionConsumer(Consumer<Exception> function): base(function) {}

}}
