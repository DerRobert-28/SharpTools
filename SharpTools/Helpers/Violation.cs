namespace DerRobert28.SharpTools.Helpers {

using System;


public sealed class Violation: Exception {

	private readonly string message;

	public static Violation ofCustom(string message)
		=> new Violation(message);

	public static readonly Exception MissingConsumer
		= new NullReferenceException("Consumer should not be NULL");

	public static readonly Exception MissingEither
		= new NullReferenceException("Either Container should not be NULL");

	public static readonly Exception MissingFunction
		= new NullReferenceException("Function must not be be NULL");

	public static readonly Exception MissingGetValue
		= new InvalidOperationException("get() called with no value present");

	public static readonly Exception MissingGetLeftValue
		= new InvalidOperationException("getLeft() called with no left value present");

	public static readonly Exception MissingMapper
		= new NullReferenceException("Mapper should not be NULL");

	public static readonly Exception MissingObject
		= new NullReferenceException("Object must not be be NULL");

	public static readonly Exception MissingOptional
		= new NullReferenceException("Optional Container should not be NULL");

	public static readonly Exception MissingString
		= new NullReferenceException("String should not be null or empty");

	public string getMessage() => message;

	private Violation(string message)
		=> this.message = $"{message}";

}}
