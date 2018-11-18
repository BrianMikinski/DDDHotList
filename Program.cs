using System;

namespace DDDHotList
{
    class Program
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
            var dump = new DirtyHouse(){
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
        }

        /// <summary>
        /// A dirty unorganized house. 
        /// 
        /// Note: The openess at which public setters are used. Unless you are
        /// absolutely sure this is the design you need, it should be avoided.
        /// 99% of the time this is not needed
        /// </summary>
        public class DirtyHouse
        {
            public int Windows  { get; set; }
            
            public int Doors { get; set; }

            public string Color { get; set; }
        }

        /// <summary>
        /// A standard house. 
        /// 
        /// Note: Notice the private setter methods. Private setters are 
        /// a significant design improvement over fully open setter methods. If you need to
        /// Access a method sparingly, use custom setter functions. Only make the setter propery 
        /// public as a last resort.
        /// 
        /// Note: Because the properties have private setters, you must construct the object
        /// using the constructor.
        /// </summary>
        public class StandardHouse
        {
            public StandardHouse(int windows, int doors, string color)
            {
                Windows = windows;
                Doors = doors;
                Color = color;
            }

            public int Windows {get; private set;}

            /// <summary>
            /// Customer setter method for setting the number of windows in the house
            /// </summary>
            /// <param name="windows"></param>
            public void SetWindows(int windows){
                Windows = windows;
            }

            public int Doors {get; private set;}

            public string Color {get; private set;}
        }

        /// <summary>
        /// A clean house.
        /// 
        /// Note: The use of readonly publicly facing methods. This means 
        /// you can reason about the object and be certain it has not been modified
        /// since it was created.
        /// </summary>
        public class CleanHouse
        {
            public CleanHouse(int windows, int doors, string color)
            {
                Windows = windows;
                Doors = doors;
                Color = color;    
            }

            public readonly int Windows;

            public readonly int Doors;

            public readonly string Color;
        }

        /// <summary>
        /// A mansion object.
        /// 
        /// Note: "Factory" style object creation. We are using static methods to standardize the creation
        /// of certain types of objects. This is combined with private constructors as a powerful technique
        /// to insure your objects are created correctly and safely
        /// </summary>
        public class Mansion 
        {
            /// <summary>
            /// Create a new mansion with a pool
            /// </summary>
            /// <param name="windows"></param>
            /// <param name="doors"></param>
            /// <param name="color"></param>
            /// <returns></returns>
            public static Mansion withPool(int windows, int doors, string color)
            {
                return new Mansion(windows, doors, color, true);
            }

            /// <summary>
            /// Create a new mansion without a pool
            /// </summary>
            /// <param name="windows"></param>
            /// <param name="doors"></param>
            /// <param name="color"></param>
            /// <returns></returns>
            public static Mansion withoutPool(int windows, int doors, string color)
            {
                return new Mansion(windows, doors, color);
            }

            private Mansion(int windows, int doors, string color, bool hasPool = false)
            {
                Windows = windows;
                Doors = doors;
                Color = color;
                HasPool = hasPool;  
            }

            /// <summary>
            /// Convert a mansion to a clean house
            /// </summary>
            /// <returns></returns>
            public CleanHouse CleanHouse()
            {
                return new CleanHouse(Windows, Doors, Color);
            }

            public readonly int Windows;

            public readonly int Doors;

            public readonly string Color;

            public readonly bool HasPool;

            public void ShowHouse()
            {
                if(HasPool)
                {
                    Console.WriteLine("Mansion with Pool:");
                }
                else
                {
                    Console.WriteLine("Mansion without Pool:");
                }

                Console.WriteLine($"    Color: {Color}");
                Console.WriteLine($"    Windows: {Windows}");
                Console.WriteLine($"    Doors: {Doors}");
            }
        }

        public class Vehicle
        {

        }

        /// <summary>
        /// Abstract base class for a motor vehicle
        /// </summary>
        public abstract class MotorVehicle
        {
        
        }
    }
}
