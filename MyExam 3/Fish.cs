class Fish : Animal
{
    public Fish(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} makes bubbles");
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} swims");
    }
}