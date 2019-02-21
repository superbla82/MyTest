using System;

class Dog
{
    public Dog(string name)
    {
        this.Name = name;
    }
    public string Name;
    public string Color;

    public void Speak() 
    {
        Console.WriteLine("My name is " + this.Name + " and I am " + this.Color);
    }

}

class Red: Dog
{
    public Red(string name) : base(name)
    {
        this.Color = "Red";
        this.Speak();
    }
}

class Blue: Dog
{
    public Blue(string name) : base(name)
    {
        this.Color = "Blue";
        this.Speak();
    }
}

class Green: Dog
{
    public Green(string name) : base(name)
    {
        this.Color = "Green";
        this.Speak();
    }
}
public class Test
{
    static void Main()
    {
        Dog e = new Blue("Bob");
        Dog b = new Red("Bill");
        Dog a = new Green("Mary");
    }
}