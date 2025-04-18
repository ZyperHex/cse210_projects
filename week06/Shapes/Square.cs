

class Square : Shape
{
    private double _side;

    public Square(string color ,double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }

    public override string ToString()
    {
        return $"Square (Color: {GetColor()}, Side: {_side}, Area: {GetArea()})";
    }
}