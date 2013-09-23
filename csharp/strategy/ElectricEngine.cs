using System;
public class ElectricEngine : IEngine 
{
	public void TurnOn() 
	{
		Console.WriteLine("bzzz!!");
	}
	public void TurnOff() 
	{
		Console.WriteLine("zap!!!");	
	}
}