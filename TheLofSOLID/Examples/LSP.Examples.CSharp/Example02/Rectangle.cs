namespace Tests
{
    public class Rectangle : IShape
    {
        public virtual uint Width { get; set; }
        public virtual uint Height { get; set; }
        public override uint Area => Width * Height;
    }
}