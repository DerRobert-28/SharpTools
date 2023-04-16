namespace DerRobert28.SharpTools.Tests.Tasks {

	using SharpTools.UserTypes;
	using SharpTools.ValueTypes;
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
		//	PRIVATE CONSTRUCTOR:
		//

		private Duplicate(): base("Duplicate") {}

	}

}
