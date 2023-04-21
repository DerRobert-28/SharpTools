namespace DerRobert28.SharpTools.Types.Activities {

	using SharpTools.Types.Containers;
	using System;

	public abstract class Task<T, R>: Activity<T, R> {

		private string name;

		public abstract Either<Exception, R> performAs(User user, T value);

		public string getTaskName() => name;

		protected Task(string name) => this.name = name;
	
	}

}
