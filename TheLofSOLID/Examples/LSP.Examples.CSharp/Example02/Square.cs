namespace Tests
{
    public class Square : Rectangle
    {
        // square weakens setter postconditions of rectangle!
        // the postcondition is weakened by removing { Rectangle.Height == oldHeight }
        public override uint Width
        {
            get => base.Width;
            set {
                base.Width = value;
                base.Height = value;
            }            
        }

        // square weakens setter postconditions of rectangle!
        // the postcondition is weakened by removing { Rectangle.Width == oldWidth }
        public override uint Height 
        {
            get => base.Height;
            set {
                base.Width = value;
                base.Height = value;
            }
        }
    }
}