// See https://aka.ms/new-console-template for more information
using System;

public abstract class Subject
{
	private List<Observer> observers = new List<Observer>();
	public void Attach(Observer observer)
	{
		observers.Add(observer);
	}
	public void Detach(Observer observer)
	{
		observers.Remove(observer);
	}
	public void Notify()
	{
		foreach (Observer o in observers)
		{
			o.Update();
		}
	}
}