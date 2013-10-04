using System;
using System.Collections.Generic;
public class WhiteBoard : IObservable
{
	private List<IObserver> Observers { get; set;}

	public WhiteBoard () 
	{
		Observers = new List<IObserver>();
	}

	public void Attach (IObserver observer)
	{
		Observers.Add(observer);
	}

	public void Detach (IObserver observer) 
	{
		Observers.Remove(observer);
	}

	public void Update (string text)
	{
		Observers.ForEach(delegate(IObserver observer)
		{
			observer.Update(text);
		});
	}
}