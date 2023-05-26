namespace DerRobert28.SharpTools.Types.Abstract.Classes
{
	using DerRobert28.SharpTools.Helpers;
	using DerRobert28.SharpTools.Types.Abstract.Interfaces;
	using DerRobert28.SharpTools.Types.Functions;

	public abstract class TAssertions
	{
		protected void assertConsumerNotNull<T>(IAcceptor<T> consumer)
		{
			if(consumer == null)
			{
				throw Violation.MissingConsumer;
			}
		}

		protected void assertHavingValue<C, T>(IOptional<C, T> optional)
		{
			if(!optional.isDefined())
			{
				throw Violation.MissingGetValue;
			}
		}

		protected void assertMapperNotNull<T, U>(Function1<T, U> mapper)
		{
			if(mapper == null)
			{
				throw Violation.MissingMapper;
			}
		}

		protected void assertProjectionIsLeft<C, L, R>(IEither<C, L, R> either)
		{
			if(either.isRight())
			{
				throw Violation.MissingGetLeftValue;
			}
		}

		protected void assertProjectionIsRight<C, L, R>(IEither<C, L, R> either)
		{
			if(either.isLeft())
			{
				throw Violation.MissingGetValue;
			}
		}
	}
}
