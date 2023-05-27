namespace DerRobert28.SharpTools.Helpers {

using DerRobert28.SharpTools.Types;
using DerRobert28.SharpTools.Types.Functions;
using System;


public sealed class Mappers<T> {

	public static readonly Function1<T, byte> toByte
		= Function1<T, byte>.of(value => byte.Parse(toString.apply(value)));

	public static readonly Function1<T, char> toChar
		= Function1<T, char>.of(value => char.Parse(toString.apply(value)));

	public static readonly Function1<T, decimal> toDecimal
		= Function1<T, decimal>.of(value => decimal.Parse(toString.apply(value)));

	public static readonly Function1<T, double> toDouble
		= Function1<T, double>.of(value => double.Parse(toString.apply(value)));

	public static readonly Function1<T, Exception> toException
		= Function1<T, Exception>.of(value => new Exception(toString.apply(value)));

	public static readonly Function1<T, float> toFloat
		= Function1<T, float>.of(value => float.Parse(toString.apply(value)));

	public static readonly Function1<T, int> toInteger
		= Function1<T, int>.of(value => int.Parse(toString.apply(value)));

	public static readonly Function1<T, long> toLong
		= Function1<T, long>.of(value => long.Parse(toString.apply(value)));

	public static readonly Function1<T, Nothing> toNothing
		= Function1<T, Nothing>.of(value => Nothing.get<Nothing>());

	public static readonly Function1<T, object> toObject
		= Function1<T, object>.of(value => Caster<object>.of(value));

	public static readonly Function1<T, short> toShort
		= Function1<T, short>.of(value => short.Parse(toString.apply(value)));

	public static readonly Function1<T, string> toString
		= Function1<T, string>.of(value => string.Format("{0}", value));

	public static readonly Function1<T, Violation> toViolation
		= Function1<T, Violation>.of(value => Violation.ofCustom(toString.apply(value)));

}}
