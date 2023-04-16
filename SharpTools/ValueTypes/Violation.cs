namespace DerRobert28.SharpTools.ValueTypes {
	
	using System;

	public sealed class Violation: Exception {

		public static readonly Exception MissingMapper =
			new NullReferenceException("Mapper shoudl not be NULL");

		public static readonly Exception MissingGetValue =
			new InvalidOperationException("get() called with no value present");

		public static readonly Exception MissingGetLeftValue =
			new InvalidOperationException("getLeft() called with no left value present");

	}

}
