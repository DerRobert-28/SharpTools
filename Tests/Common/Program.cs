﻿namespace DerRobert28.Tests {

using DerRobert28.SharpTools.Types;
using DerRobert28.SharpTools.Types.Consumers;
using DerRobert28.SharpTools.Types.Suppliers;
using DerRobert28.Tests.Tasks;
using System;


public class Program {

	static void Main() {
		
		var Robert = User.named("Robert");
		var resultToConsole = IntConsumer.of(x => Console.WriteLine("Der Wert ist: {0}", x));
		var errorToConsole = ViolationConsumer.of(e => Console.WriteLine(e.Message));
		var waitForEnter = StringSupplier.of(() => Console.ReadLine());

		Robert.attemptsTo_(
				
			Duplicate.theValue(123)
			
		)
		.peek(resultToConsole)
		.peekLeft(errorToConsole)
		;

		waitForEnter.get();

	}

}}
