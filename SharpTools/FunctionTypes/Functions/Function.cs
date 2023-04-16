namespace DerRobert28.SharpTools.FunctionTypes.Functions {

	public abstract class Function: IFunction {

		protected readonly int arity;

		public int getArity() => arity;
		
		protected Function(int arity) => this.arity = arity;

	}

}
