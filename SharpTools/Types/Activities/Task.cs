using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Containers;
using System;


namespace DerRobert28.SharpTools.Types.Activities {

	public abstract class Task<T, R>: Activity<T, R> {

		private string name;

		public abstract Either<Violation, R> performAs(User user, T value);

		public string getTaskName()
			=> name;

		protected Task(string name)
			=> this.name = name;
	
	}

}
