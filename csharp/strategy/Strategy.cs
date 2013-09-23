using System;
class Strategy 
{
	public static void Main () 
	{
		//we create a petrol car by calling the car constructor and passing a Petrol engine instance.
		var petrolCar = new Car(new PetrolEngine());
		Console.WriteLine("using a petrol car");
		petrolCar.TurnOnOff();

		//we create an electric car by calling the car contructor and passing an electric engine instance.
		var electricCar = new Car(new ElectricEngine());
		Console.WriteLine("using an electric car");
		electricCar.TurnOnOff();

	}	
}
 