﻿namespace DerRobert28.SharpTools.Types.Consumers {


public class ByteConsumer: Consumer<byte> {

	public static new ByteConsumer of(Consumer<byte> function)
		=> new ByteConsumer(function);

	private ByteConsumer(Consumer<byte> function): base(function) {}

}}
