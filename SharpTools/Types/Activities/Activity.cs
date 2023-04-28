using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Containers;
using System;


namespace DerRobert28.SharpTools.Types.Activities {

	public interface Activity<T, R> {

		Either<Violation, R> performAs(User user, T value);

	}

}
