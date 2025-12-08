public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle() : base()
    {
        _shape = "rectangle";
        _length = 1;
        _width = 2;
    }

    public Rectangle(double length, double width)
    {
        _shape = "rectangle";
        _length = length;
        _width = width;
    }

    public Rectangle(string color, double length, double width) : base(color)
    {
        _color = color;
        _shape = "rectangle";
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        _area = _length * _width;
        return _area;
    }
}