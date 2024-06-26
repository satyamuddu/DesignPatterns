﻿namespace State
{
	public class Context
	{
		State state;
		// Constructor
		public Context(State state)
		{
			this.State = state;
		}
		// Gets or sets the state
		public State State
		{
			get { return state; }
			set
			{
				state = value;
				Console.WriteLine("State: " + state.GetType().Name);
			}
		}
		public void Request()
		{
			state.Handle(this);
		}
	}
}