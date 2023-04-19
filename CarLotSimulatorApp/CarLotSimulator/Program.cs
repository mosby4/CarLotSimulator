using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var Lot = new CarLot();
           
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            var DreamCar = new Car();
            DreamCar.Year = 1961;
            DreamCar.Make = "Ferrari";
            DreamCar.Model = "250 GT California";
            DreamCar.EngineNoise = "v12 screaming!";
            DreamCar.HonkNoise = "Move b#%## GET OUT THE WAY!";
            //DreamCar.IsDriveable = "Drive at your own RISK!";

            Lot.Cars.Add(DreamCar);

            var Ferrari = new Car()
            {
                Year = 1962,
                Make = "Ferrari",
                Model = "250 gto",
                EngineNoise = "BRAAAAAAAP!",
                HonkNoise = "Beep! Beep!",
                //IsDriveable = "Drive at your own Risk!",
            };

            Lot.Cars.Add(Ferrari);

            var MyfirstTruck = new Car(1983, "Chevy","C10","Rumbleee","Hooonk",true );

            Ferrari.MakeEngineNoise(Ferrari.EngineNoise);
            Console.WriteLine();
            MyfirstTruck.MakeEngineNoise(MyfirstTruck.EngineNoise);
            Console.WriteLine();
            DreamCar.MakeEngineNoise(DreamCar.EngineNoise);
            Console.WriteLine();
            Lot.Cars.Add(MyfirstTruck);

            foreach (var Car in Lot.Cars)
            {
                Console.WriteLine($"Year:{Car.Year} Make: {Car.Make} Model: {Car.Model} ");
            }
            var vehicle = new Car()
            {
                Year = 2023,
                Make = "International",
                Model = "Scout",
            };
            var autoMobile = new Car()
            {
                Year = 2010,
                Make = "Volkswagen",
                Model = "Jetta",
            };

            var dailyCommuter = new Car()
            {
                Year = 2010,
                Make = "Chevrolet",
                Model = "Silveradoooooo",
            };

            Console.WriteLine($"The total number of cars created is {CarLot.numberOfCars}");

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
