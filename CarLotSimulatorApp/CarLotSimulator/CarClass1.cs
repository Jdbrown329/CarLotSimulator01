using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class CarClass1
    {
        public string Make { get; set; }       //Create a seperate class file called Car
                                               //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
                                               //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
                                               //The methods should take one string parameter: the respective noise property
        public string Model { get; set; } 
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable{ get; set; } 
        public int Year { get; set; }
    }
}  
public class CarLot01
{
    public string ListOfCars { get; set; } //Create a CarLot class
                  //It should have at least one property: a List of cars
                  //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                  //At the end iterate through the list printing each of car's Year, Make, and Model to the console
}

