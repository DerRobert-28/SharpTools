﻿namespace SharpTools.ValueTypes {
	
	using System;

	public sealed class Violation: Exception {

		public static readonly Exception MissingMapper =
			new NullReferenceException("Mapper shoudl not be NULL");

		public static readonly Exception MissingGetValue =
			new InvalidOperationException("get() called with no value present");

		public static readonly Exception MissingPeekValue =
			new InvalidOperationException("peek() called with no value present");

		public static readonly Exception MissingGetLeftValue =
			new InvalidOperationException("getLeft() called with no left value present");

		public static readonly Exception MissingPeekLeftValue =
			new InvalidOperationException("peekLeft() called with no left value present");

	}

}
