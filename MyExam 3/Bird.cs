class Bird : Animal
{
    public Bird(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} chirps");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} flies");
    }
}