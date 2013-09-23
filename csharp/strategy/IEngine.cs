//This is the strategy.
public interface IEngine 
{
	//concrete implementations of this strategy must fulfill the following contract:
	void TurnOn();
	void TurnOff();
}