﻿namespace DerRobert28.SharpTools.Types.Abstract.Classes
{
	using DerRobert28.SharpTools.Types.Abstract.Interfaces;
	using System;

	public abstract class TAcceptor<T>: IAcceptor<T>
	{
		protected readonly Action<T> function;

		public IAcceptor<T> accept() => this;

		public void accept(T value) => function.Invoke(value);

		protected TAcceptor(Action<T> function) => this.function = function;
	}
}
