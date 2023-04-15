namespace SharpTools.UserTypes {
	
	using System;
	using ValueTypes;

	public interface Activity<T, R> {

		Either<Exception, R> performAs(User user, T value);
	
	}

}
