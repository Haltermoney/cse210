using System.Runtime.InteropServices.Marshalling;

public class Shape
{
    protected string _color;
    protected double _area = 0;
    protected string _shape = "shape";


    public Shape()
    {
        _color = "blue";
    }

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return _area;
    }
    public string GetShape()
    {
        return _shape;
    }

    public string DisplayShapeInfo()
    {
        return $"The area of the {GetColor()} {GetShape()} is {GetArea()}.";
    }
}