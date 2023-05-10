using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Interfaces;
using DerRobert28.SharpTools.Types.Functions;
using System;

namespace DerRobert28.SharpTools.Types.Abstract.Classes {

	public abstract class TFunction<C, R>: IFunction<C, R> {

		protected readonly int arity;

		public int getArity()
			=> arity;

		public C apply()
			=> Caster<C>.of(this);

		protected TFunction(int arity)
			=> this.arity = arity;

	}

}
