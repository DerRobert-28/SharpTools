namespace SharpTools {

	using SharpTools.FunctionTypes;
	using SharpTools.UserTypes;
	using SharpTools.ValueTypes;
	using System;
	using System.Security.Cryptography.X509Certificates;

	class Duplicate: Task<int, int> {
		
		//
		//	PUBLIC METHODS:
		//

		public override Either<Exception, int> performAs(User user, int number) {
			return Either<Exception, int>.right(2 * number);
		}
		
		public static Duplicate theValue() => new Duplicate();

		//
		//	PRIVATE CONSTRUCTOR:
		//

		private Duplicate(): base("Duplicate") {}
	}

	class Program {

		static void Main() {
			
			var Robert = User.named("Robert");
			var resultToConsole = Consumer.ofInt(x => Console.WriteLine("Der Wert ist: {0}", x));
			var errorToConsole = Consumer.ofException(e => Console.WriteLine(e.Message));
			
			Robert.attemptsTo(
				
				Duplicate.theValue()
			
			)
			.apply(123)
			.peek(resultToConsole)
			.peekLeft(errorToConsole)
			;

			Console.ReadLine();

		}

	}

}
