namespace DerRobert28.SharpTools.Types {

using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Activities;
using DerRobert28.SharpTools.Types.Containers;
using DerRobert28.SharpTools.Types.Functions;


public class User {
		
	private readonly string name;

	public static User named(string name) => new User(name);

	public string getName() => name;

	public Function1<T, Either<Violation, R>> attemptsTo<T, R>(Activity<T, R> activity)
		=> Function1<T, Either<Violation, R>>.of(param => activity.performAs(this, param));

	public Either<Violation, R> attemptsTo_<T, R>(Activity<T, R> activity)
		=> activity.performAs(this, Nothing.get<T>());

	private User(string name) => this.name = name;

}}
