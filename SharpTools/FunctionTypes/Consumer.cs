namespace SharpTools.FunctionTypes {

	using System;

	public class Consumer {

		public static Consumer<bool> ofBool(Consumer<bool>.Delegate consumer)
			=> Consumer<bool>.of(consumer);

		public static Consumer<byte> ofByte(Consumer<byte>.Delegate consumer)
			=> Consumer<byte>.of(consumer);

		public static Consumer<short> ofShort(Consumer<short>.Delegate consumer)
			=> Consumer<short>.of(consumer);

		public static Consumer<int> ofInt(Consumer<int>.Delegate consumer)
			=> Consumer<int>.of(consumer);

		public static Consumer<long> ofLong(Consumer<long>.Delegate consumer)
			=> Consumer<long>.of(consumer);

		public static Consumer<float> ofFloat(Consumer<float>.Delegate consumer)
			=> Consumer<float>.of(consumer);

		public static Consumer<double> ofDouble(Consumer<double>.Delegate consumer)
			=> Consumer<double>.of(consumer);

		public static Consumer<decimal> ofDouble(Consumer<decimal>.Delegate consumer)
			=> Consumer<decimal>.of(consumer);

		public static Consumer<char> ofChar(Consumer<char>.Delegate consumer)
			=> Consumer<char>.of(consumer);

		public static Consumer<string> ofString(Consumer<string>.Delegate consumer)
			=> Consumer<string>.of(consumer);

		public static Consumer<Exception> ofException(Consumer<Exception>.Delegate consumer)
			=> Consumer<Exception>.of(consumer);

	}


	public class Consumer<T> {

		public delegate void Delegate(T value);
		private readonly Delegate consumer;

		public static Consumer<T> of(Delegate consumer) => new Consumer<T>(consumer);

		public Consumer<T> accept() => this;
		public void accept(T value) => consumer.Invoke(value);

		private Consumer(Delegate consumer) => this.consumer = consumer;
	
	}

}
