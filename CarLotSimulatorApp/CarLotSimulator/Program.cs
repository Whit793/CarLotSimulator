using System;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            var bryansCar = new Car();
            bryansCar.Make = "Honda";
            bryansCar.Model = "Accord";
            bryansCar.Year = 2004;
            bryansCar.EngineNoise = "V4";
            bryansCar.HonkNoise = "High pitched beep";
            bryansCar.IsDriveable = true;

            var katesCar = new Car()
            {
                Make = "Volkswagon",
                Model = "Tiguan",
                Year = 2008,
                EngineNoise = "V6",
                HonkNoise = "mid range beep",
                IsDriveable = false,
            };

            var ericsCar = new Car(2018, "Honda", "Civic Type-R", "turbo V6", "mid range honk", true);




            //Set the properties for each of the cars
            //Call each of the methods for each car
            bryansCar.MakeEngineNoise(bryansCar.EngineNoise);
            katesCar.MakeEngineNoise(katesCar.EngineNoise);
            ericsCar.MakeEngineNoise(ericsCar.EngineNoise);


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
