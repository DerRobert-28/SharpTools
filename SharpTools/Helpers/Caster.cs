namespace DerRobert28.SharpTools.Helpers {


public sealed class Caster<T> {

	public static T of(object obj) => (T) obj;

	public static T ofNull() => of(null);

}}
