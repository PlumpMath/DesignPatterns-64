using System;
public class PetrolEngine : IEngine 
{
	public void TurnOn() 
	{
		Console.WriteLine("Vroom!!");
	}
	public void TurnOff() 
	{
		Console.WriteLine("click");	
	}
 }