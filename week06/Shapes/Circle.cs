class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

        public override string ToString()
    {
        return $"Circle (Color: {GetColor()}, Radius: {_radius}, Area: {GetArea():F2})";
    }
}