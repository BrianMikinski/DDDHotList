using System;
using System.Collections.Generic;

namespace DDDHotList
{
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

        private Mansion(int windows, int doors, string color, bool hasPool = false, IEnumerable<string> roomNames = null)
        {
            Windows = windows;
            Doors = doors;
            Color = color;
            HasPool = hasPool;
            RoomNames = roomNames;
        }

        /// <summary>
        /// Convert a mansion to a clean house
        /// </summary>
        /// <returns></returns>
        public CleanHouse CleanHouse()
        {
            return new CleanHouse(Windows, Doors, Color);
        }

        /// <summary>
        /// Use of IEnumerable means that object cannot be modofied inadvertantly by typical add/delete/sort
        /// collection operations but still allows object to be iterated over in an foreach loop
        /// </summary>
        public readonly IEnumerable<string> RoomNames;

        public readonly int Windows;

        public readonly int Doors;

        public readonly string Color;

        public readonly bool HasPool;

        public void ShowHouse()
        {
            if (HasPool)
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
}