namespace DerRobert28.SharpTools.UserTypes {

	using SharpTools.FunctionTypes;
	using System;
	using ValueTypes;

	public class User {
		
		//
		//	PRIVATE FIELDS:
		//

		private readonly string name;

		//
		//	PUBLIC METHODS:
		//

		public static User named(string name) => new User(name);

		public string getName() => name;

		//public Function1<T, Either<Exception, R>> attemptsTo(Activity<T, R> activity) {
		//	Function1<T, Either<Exception, R>>.of(param -> activity.performAs(this, param));
		//}
		public Function1<T, Either<Exception, R>> attemptsTo<T, R>(Activity<T, R> activity) {
			return Function1<T, Either<Exception, R>>
				.of(param => activity.performAs(this, param));
		}

		private User(string name) => this.name = name;

	}
}
