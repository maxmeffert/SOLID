namespace Example02
{
    public class Rectangle : IShape
    {
        public virtual uint Width { get; set; }
        public virtual uint Height { get; set; }
        public uint Area => Width * Height;
    }
}