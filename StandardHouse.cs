namespace DDDHotList
{
    /// <summary>
    /// A standard house. 
    /// 
    /// Note: Notice the private setter methods. Private setters are 
    /// a significant design improvement over fully open setter methods. If you need to
    /// Access a method sparingly, use custom setter functions. Only make the setter property 
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

        public int Windows { get; private set; }

        /// <summary>
        /// Customer setter method for setting the number of windows in the house
        /// </summary>
        /// <param name="windows"></param>
        public void SetWindows(int windows)
        {
            Windows = windows;
        }

        public int Doors { get; private set; }

        public string Color { get; private set; }
    }
}