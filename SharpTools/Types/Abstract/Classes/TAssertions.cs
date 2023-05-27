namespace DerRobert28.SharpTools.Types.Abstract.Classes {

using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Interfaces;
using DerRobert28.SharpTools.Types.Functions;


public abstract class TAssertions {

	protected void assertConsumerNotNull<T>(IAcceptor<T> consumer) {
		if(Equals(consumer, null)) {
			throw Violation.MissingConsumer;
		}
	}

	protected void assertEitherNotNull<C, L, R>(IEither<C, L, R> either) {
		if(Equals(either, null)) {
			throw Violation.MissingEither;
		}
	}

	protected void assertFunctionNotNull(object function) {
	//	I am too lazy to implement assertFunctionNotNull() for every Func<> ...
		if(Equals(function, null)) {
			throw Violation.MissingFunction;
		}
	}

	protected void assertHavingValue<C, T>(IOptional<C, T> optional) {
	//	No assertOptionalNotNull() call because of SRP !!
		if(optional.isUndefined()) {
			throw Violation.MissingGetValue;
		}
	}

	protected void assertMapperNotNull<T, U>(Function1<T, U> mapper) {
		if(Equals(mapper, null)) {
			throw Violation.MissingMapper;
		}
	}

	protected void assertObjectNotNull(object any) {
		if(Equals(any, null)) {
			throw Violation.MissingObject;
		}
	}

	protected void assertOptionalNotNull<C, T>(IOptional<C, T> optional) {
		if(Equals(optional, null)) {
			throw Violation.MissingOptional;
		}
	}

	protected void assertProjectionIsLeft<C, L, R>(IEither<C, L, R> either) {
	//	No assertEitherNotNull() call because of SRP !!
		if(either.isRight()) {
			throw Violation.MissingGetLeftValue;
		}
	}

	protected void assertProjectionIsRight<C, L, R>(IEither<C, L, R> either) {
	//	No assertEitherNotNull() call because of SRP !!
		if(either.isLeft()) {
			throw Violation.MissingGetValue;
		}
	}

	protected void assertStringNotEmpty(string str) {
	//	No assertStringNotNull() call because of SRP !!
		if(string.Equals(str.Trim(), string.Empty)) {
			throw Violation.MissingString;
		}
	}

	protected void assertStringNotNull(string str) {
		if(Equals(str, null)) {
			throw Violation.MissingString;
		}
	}

	protected void assertStringNotNullOrEmpty(string str) {
		assertStringNotNull(str);
		assertStringNotEmpty(str);
	}

}}
