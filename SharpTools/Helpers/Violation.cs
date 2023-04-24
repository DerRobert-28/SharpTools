using System;

namespace DerRobert28.SharpTools.Helpers {

	public sealed class Violation: Exception {

		protected readonly string message;

		public static Violation ofCustom(string message)
			=> new Violation(message);

		public static readonly Exception MissingMapper =
			new NullReferenceException("Mapper should not be NULL");

		public static readonly Exception MissingGetValue =
			new InvalidOperationException("get() called with no value present");

		public static readonly Exception MissingGetLeftValue =
			new InvalidOperationException("getLeft() called with no left value present");

		public string getMessage()
			=> message;

		private Violation(string message) {
			this.message = message;
			Exception e;
		}

	}

}
