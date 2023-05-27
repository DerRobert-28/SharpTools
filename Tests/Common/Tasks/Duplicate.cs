namespace DerRobert28.Tests.Tasks {

using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types;
using DerRobert28.SharpTools.Types.Activities;
using DerRobert28.SharpTools.Types.Containers;

	
class Duplicate: Task<Nothing, int> {

	readonly int number;
		
	public override Either<Violation, int> performAs(User user, Nothing dummy)
		=> Either<Violation, int>.right(2 * number);
		
	public static Duplicate theValue(int number)
		=> new Duplicate(number);

	private Duplicate(int number):
		base("Duplicate") {
		this.number = number;
	}

}}
