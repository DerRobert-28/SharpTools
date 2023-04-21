namespace DerRobert28.Tests {

	using SharpTools.Types.Containers;
	using SharpTools.Types;
	using SharpTools.Types.Consumers;
	using Tests.Tasks;
	using System;

	class Program {

		static void Main() {

		
			var Robert = User.named("Robert");
			//var resultToConsole = IntConsumer.of(x => Console.WriteLine("Der Wert ist: {0}", x));
			var resultToConsole = Consumer<int>.of(x => Console.WriteLine("Der Wert ist: {0}", x));
			var errorToConsole = ExceptionConsumer.of(e => Console.WriteLine(e.Message));


			Robert.attemptsTo(
				
				Duplicate.theValue()
			
			)
			.apply(123)
			.peek(resultToConsole)
			.peekLeft(errorToConsole);

			Console.ReadLine();

		}

	}

}
