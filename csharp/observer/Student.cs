using System;
public class Student : IObserver
{
	public void Update(string text)
	{
		Console.WriteLine("I am a student taking notes {0}", text);
	}
}