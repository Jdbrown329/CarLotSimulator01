using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args, CarClass1 carClass1)
        {
           //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            // Print car Information and weather it is driveable 

            var myCar = new CarClass1();
            {
                myCar.Make = "Hyundai";
                myCar.Model = "Sonnata";
                myCar.Year = 2003;
                myCar.EngineNoise = "Vroom";
                myCar.HonkNoise = "BopBop";
                myCar.IsDriveable = true;

                Console.WriteLine($" My car is a {myCar.Make} {myCar.Model} made in the year {myCar.Year} and its engine goes {myCar.EngineNoise} and the horn goes {myCar.HonkNoise} if you hear I am driving it that is {myCar.IsDriveable}");

            }
            var johnsCar = new CarClass1();
            { johnsCar.Make = "Ford";
              johnsCar.Model = "Explorer";
              johnsCar.Year = 2012;
              johnsCar.EngineNoise = "grrr";
              johnsCar.HonkNoise = "Honk";
              johnsCar.IsDriveable = false;
                Console.WriteLine($" John's car is a {johnsCar.Make} {johnsCar.Model} made in the year {johnsCar.Year} and its engine goes {johnsCar.EngineNoise} and the horn goes {johnsCar.HonkNoise} if you hear John is driving it that is {johnsCar.IsDriveable}");


            }
            var jimsCar = new CarClass1();
            {
                jimsCar.Make = "Chevy";
                jimsCar.Model = "Bolt ";
                jimsCar.Year = 2021;
                jimsCar.EngineNoise = "*smoothsilence*";
                jimsCar.HonkNoise = "Sounds like Electronica";
                jimsCar.IsDriveable= true;

                Console.WriteLine($" Jim's car is a {jimsCar.Make} {jimsCar.Model} made in the year {jimsCar.Year} and its engine goes {jimsCar.EngineNoise} and the horn goes {jimsCar.HonkNoise} if you hear Jim is driving it that is {jimsCar.IsDriveable}");
            }
            Console.WriteLine($"Number of cars created:{CarClass1.numberOfCars}");
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
