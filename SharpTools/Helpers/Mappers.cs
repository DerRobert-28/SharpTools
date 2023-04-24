using DerRobert28.SharpTools.Types.Functions;
using System;

namespace DerRobert28.SharpTools.Helpers {

	public sealed class Mappers<T> {

		public static readonly Function1<T, string> toString
			= Function1<T, string>.of(value => String.Format("{0}", value));

	}

}
