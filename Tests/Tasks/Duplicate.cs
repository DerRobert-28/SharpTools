namespace DerRobert28.Tests.Tasks {

	using SharpTools.Types;
	using SharpTools.Types.Activities;
	using SharpTools.Types.Containers;
	using System;
	
	class Duplicate: Task<int, int> {
		
		//
		//	PUBLIC METHODS:
		//

		public override Either<Exception, int> performAs(User user, int number) {
			return Either<Exception, int>.right(2 * number);
		}
		
		public static Duplicate theValue() => new Duplicate();

		//
		//	CONSTRUCTOR:
		//

		private Duplicate(): base("Duplicate") {}

	}

}
