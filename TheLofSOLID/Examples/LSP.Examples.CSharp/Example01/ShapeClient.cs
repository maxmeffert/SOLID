namespace Example01
{
    public class ShapeClient
    {
        // DrawShape cannot be used with all (possible) subtypes of Shape.
        // Shape is not a super type regarding the Draw-behavior, hence, Liskov-/"Behavioral"-substitution is impossible.
        // Also, this violates the Open/Closed Principle.
        // It's just not a good method ;-) 
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