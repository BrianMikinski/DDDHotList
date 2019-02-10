namespace DDDHotList
{
    /// <summary>
    /// A dirty unorganized house. 
    /// 
    /// Note: The openess at which public setters are used. Unless you are
    /// absolutely sure this is the design you need, it should be avoided.
    /// 99% of the time this is not needed
    /// </summary>
    public class DirtyHouse
    {
        public int Windows { get; set; }

        public int Doors { get; set; }

        public string Color { get; set; }
    }
}