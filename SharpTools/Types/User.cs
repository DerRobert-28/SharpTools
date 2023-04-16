namespace DerRobert28.SharpTools.Types {

	using Activities;
	using Containers;
	using Functions;
	using System;

	public class User {
		
		private readonly string name;

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
