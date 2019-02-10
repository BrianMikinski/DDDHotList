using System;

namespace DDDHotList
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /**
             * Ideally for the "house" set of classes, we would use a type of inheritance structure
             * to share code writing the house name, color, windows, doors, etc to the console.
             * In these examples, we've largely ingored using inheritance instead focusing on
             * property getter and setter strategies as opposed to good inheritance practices.
             */

            // dirty house with open, public setters
            Console.WriteLine("Dirty House:");
            var dump = new DirtyHouse()
            {
                Windows = 12,
                Doors = 5,
                Color = "Black"
            };

            Console.WriteLine($"    Color: {dump.Color}");

            // standard house with private setters;
            Console.WriteLine($"Standard House:");
            var standardHouse = new StandardHouse(18, 10, "Blue");
            standardHouse.SetWindows(5);

            Console.WriteLine($"    Color: {standardHouse.Color}");

            // Clean house with readonly properties
            Console.WriteLine("Clean House:");
            var cleanHouse = new CleanHouse(17, 9, "Light Blue");

            Console.WriteLine($"    Color: {cleanHouse.Color}");

            // Mansion with pool

            var mansionWithPool = Mansion.withPool(27, 19, "Tope");
            mansionWithPool.ShowHouse();

            var mansionWithoutPool = Mansion.withoutPool(33, 23, "Purple");
            mansionWithoutPool.ShowHouse();

            var fordExplorer = new SportUtilityVehicle("Ford", "Explorer", 1000, 2000);

            fordExplorer.TestDrive();
        }
    }
}