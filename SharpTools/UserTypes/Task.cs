namespace DerRobert28.SharpTools.UserTypes {
	
	using System;
	using ValueTypes;

	public abstract class Task<T, R>: Activity<T, R> {

		protected string name;

		public abstract Either<Exception, R> performAs(User user, T value);

		protected Task(string name) => this.name = name;
	
	}

}
