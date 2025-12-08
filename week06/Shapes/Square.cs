public class Square : Shape
{
    private double _side;
    

    public Square() : base()
    {
        _side = 2;
        _shape = "square";
    }

    public Square(double side)
    {
        _side = side;
        _shape = "square";
    }
    public Square(string color, double side) : base(color)
    {
        _color = color;
        _side = side;
        _shape = "square";
    }

    public override double GetArea()
    {
        _area = _side * _side;
        return _area;
    }

    
}