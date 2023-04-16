namespace DerRobert28.SharpTools.FunctionTypes {

	/*
	using System;
	using ValueTypes;

	public class Supplier {

		public static Supplier<bool> ofBool(Supplier<bool>.Delegate supplier)
			=> Supplier<bool>.of(supplier);

		public static Supplier<byte> ofByte(Supplier<byte>.Delegate supplier)
			=> Supplier<byte>.of(supplier);

		public static Supplier<short> ofShort(Supplier<short>.Delegate supplier)
			=> Supplier<short>.of(supplier);

		public static Supplier<int> ofInt(Supplier<int>.Delegate supplier)
			=> Supplier<int>.of(supplier);

		public static Supplier<long> ofLong(Supplier<long>.Delegate supplier)
			=> Supplier<long>.of(supplier);

		public static Supplier<float> ofFloat(Supplier<float>.Delegate supplier)
			=> Supplier<float>.of(supplier);

		public static Supplier<double> ofDouble(Supplier<double>.Delegate supplier)
			=> Supplier<double>.of(supplier);

		public static Supplier<decimal> ofDouble(Supplier<decimal>.Delegate supplier)
			=> Supplier<decimal>.of(supplier);

		public static Supplier<char> ofChar(Supplier<char>.Delegate supplier)
			=> Supplier<char>.of(supplier);

		public static Supplier<string> ofString(Supplier<string>.Delegate supplier)
			=> Supplier<string>.of(supplier);

		public static Supplier<Exception> ofException(Supplier<Exception>.Delegate supplier)
			=> Supplier<Exception>.of(supplier);

	}
	*/

	public class Supplier<T> {

		public delegate T Delegate();
		private readonly Delegate supplier;

		public static Supplier<T> of(Delegate supplier) => new Supplier<T>(supplier);

		public T get() => supplier.Invoke();

		public Supplier<T> peek(Consumer<T> consumer) {
			consumer.accept(get());
			return this;
		}

		protected Supplier(Delegate supplier) => this.supplier = supplier;
	
	}
}
