class Circle : Shape
{
    double PI=3.14;
    public double Radius { get; set; }

    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return PI * Radius * Radius;
    }

    public override double GetPerimeter()
    {
        return 2 * PI * Radius;
    }
}