using System;
public class Car
{
	
	private IEngine Engine { get; set; }

	public Car(IEngine engine) 
	{
		Engine = engine;
	}

	public void TurnOnOff () 
	{
		Engine.TurnOn();
		Engine.TurnOff();
	}
}