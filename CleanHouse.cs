namespace DDDHotList
{
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
}