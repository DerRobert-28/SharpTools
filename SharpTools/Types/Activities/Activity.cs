namespace DerRobert28.SharpTools.Types.Activities {
	
	using System;
	using ValueTypes;

	public interface Activity<T, R> {

		Either<Exception, R> performAs(User user, T value);
	
	}

}
