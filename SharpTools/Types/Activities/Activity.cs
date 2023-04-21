namespace DerRobert28.SharpTools.Types.Activities {

	using Containers;
	using System;

	public interface Activity<T, R> {

		Either<Exception, R> performAs(User user, T value);

	}

}
