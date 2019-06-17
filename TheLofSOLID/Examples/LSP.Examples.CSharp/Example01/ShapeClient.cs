namespace Example01
{
    public class ShapeClient
    {
        public string DrawShape(Shape shape) 
        {
            if (shape is Rectangle rectangle) 
            {
                return rectangle.DrawRectangle();
            }
            else if (shape is Circle circle) 
            {
                return circle.DrawCircle();
            }            
            return string.Empty;
        }
    }
}