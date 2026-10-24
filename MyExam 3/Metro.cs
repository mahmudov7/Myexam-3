class Metro : Transport
{
    public Metro() : base("Metro")
    {
    }

    public override double CalculateFare(double km)
    {
        if (km <= 10)
        {
            return 2;
        }
        else
        {
            return 4;
        }
    }
}