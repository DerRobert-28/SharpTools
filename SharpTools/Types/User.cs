using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Activities;
using DerRobert28.SharpTools.Types.Containers;
using DerRobert28.SharpTools.Types.Functions;
using System;

namespace DerRobert28.SharpTools.Types {

	public class User {
		
		private readonly string name;

		public static User named(string name) => new User(name);

		public string getName() => name;

		public Function1<T, Either<Violation, R>> attemptsTo<T, R>(Activity<T, R> activity) {
			return Function1<T, Either<Violation, R>>
				.of(param => activity.performAs(this, param));
		}

		public Either<Violation, R> attemptsTo_<T, R>(Activity<T, R> activity) {
			return activity.performAs(this, Nothing.get<T>());
		}

		private User(string name) => this.name = name;

	}

}
