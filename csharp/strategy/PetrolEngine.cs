using System;
//this is a concrete strategy.
public class PetrolEngine : IEngine 
{
	//implementation differ between strategies.
	public void TurnOn() 
	{
		Console.WriteLine("Vroom!!");
	}
	public void TurnOff() 
	{
		Console.WriteLine("click");	
	}
 }