﻿namespace DerRobert28.SharpTools.Types.Activities {

using DerRobert28.SharpTools.Helpers;
using DerRobert28.SharpTools.Types.Abstract.Classes;
using DerRobert28.SharpTools.Types.Containers;


public abstract class Task<T, R>: TAssertions, Activity<T, R> {

	private string name;

	public abstract Either<Violation, R> performAs(User user, T value);

	public string getTaskName() => name;

	protected Task(string name) {
		assertStringNotNullOrEmpty(name);
		this.name = name;
	}

}}
