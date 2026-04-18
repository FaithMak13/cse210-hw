public class Circle : Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * _radius;
    }
}
