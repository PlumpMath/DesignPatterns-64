using System;
//this is a concrete strategy.
public class ElectricEngine : IEngine 
{
	//implementation differ between strategies.
	public void TurnOn() 
	{
		Console.WriteLine("bzzz!!");
	}
	public void TurnOff() 
	{
		Console.WriteLine("zap!!!");	
	}
}