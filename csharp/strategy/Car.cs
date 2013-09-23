using System;

//This is the context.
public class Car
{
	//The context contains a strategy.
	private IEngine Engine { get; set; }

	//accept a concrete strategy in the constructor.
	public Car(IEngine engine) 
	{
		Engine = engine;
	}

	//execute the strategy strategy
	public void TurnOnOff () 
	{
		Engine.TurnOn();
		Engine.TurnOff();
	}
}