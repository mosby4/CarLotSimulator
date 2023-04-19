using System;
using System.Collections.Generic;
//Exercise 2: Building on our car lot simulator project,
//create a CarLot class with a static field called numberOfCars.
//Have this number only increment when in our program we create a new Car.
//From there create 3 cars in the Main() and then each time you create a car,
//do a Console.WriteLine() printing the current number of cars in the car lot. 

namespace CarLotSimulator
{
	public class CarLot
	{
		public CarLot()
		{
		}
		public List<Car> Cars = new List<Car>();

		public static int numberOfCars = 1;
		
	}
}

