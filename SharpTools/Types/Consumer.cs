namespace DerRobert28.SharpTools.Types {

	using Abstract.Classes;

	public class Consumer<T>: TAcceptor<T> {
		
		public static Consumer<T> of(Delegate consumer) => new Consumer<T>(consumer);

		protected Consumer(Delegate consumer): base(consumer) {}
	
	}

}
