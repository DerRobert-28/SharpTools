namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	using Interfaces;

	public abstract class TFunction: IFunction {

		protected readonly int arity;

		public int getArity() => arity;
		
		protected TFunction(int arity) => this.arity = arity;

	}

}
