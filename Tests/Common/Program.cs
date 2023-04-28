namespace DerRobert28.Tests.Common {

	using SharpTools.FunctionTypes;
	using SharpTools.FunctionTypes.Consumers;
	using SharpTools.Tests.Tasks;
	using SharpTools.UserTypes;
	using SharpTools.ValueTypes;
	using System;
	
	class Program {

		static void Main() {
			
			var Robert = User.named("Robert");
			var resultToConsole = IntConsumer.of(x => Console.WriteLine("Der Wert ist: {0}", x));
			var errorToConsole = Consumer.ofException(e => Console.WriteLine(e.Message));
			
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
