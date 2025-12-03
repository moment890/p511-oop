using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop {
    // Class representing an automobile
    public class Automobile {
        // Property to store the brand of the vehicle
        public string Brand { get; set; }

        // Method that prints a message when the engine starts
        public void CarLed() {
            Console.WriteLine($"The car of brand {Brand} has started!");
        }
    }

    // Class representing a driver
    public class Driver {
        // Property to store the driver's name
        public string Name { get; set; }

        // Method that simulates driving by starting a specified car model
        public void DriveCar(string carBrand) {
            // Create an instance of the Automobile class and assign its brand
            Automobile car = new Automobile { Brand = carBrand };

            // Call the method to start the car's engine
            car.CarLed();
        }
    }

    internal class Program {
        static void Main(string[] args) {
            // Create a driver object and specify their name
            Driver driver = new Driver { Name = "Artyom" };

            // The driver drives a car of brand "BNW"
            driver.DriveCar("BNW");

            Console.ReadKey();
        }
    }
}