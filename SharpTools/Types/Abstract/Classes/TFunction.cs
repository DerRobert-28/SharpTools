using DerRobert28.SharpTools.Types.Abstract.Interfaces;

namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	public abstract class TFunction<R>: IFunction<R> {

		protected readonly int arity;

		public int getArity()
			=> arity;
		
		protected TFunction(int arity)
			=> this.arity = arity;

		public abstract R apply();

	}

}
