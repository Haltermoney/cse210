public class Circle : Shape
{
    private double _radius;

    public Circle() : base()
    {
        _shape = "circle";
        _radius = 1;
    }

    public Circle(double radius)
    {
        _radius = radius;
        _shape = "circle";
    }

    public override double GetArea()
    {
        _area = Math.PI * _radius * _radius;
        return Math.Round(_area, 2);
    }
}