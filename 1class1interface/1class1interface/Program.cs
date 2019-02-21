using System;


public interface IPizza
{
    void Order();
}

public class PepperoniPizza : IPizza
{
    public void Order()
    {
        Console.WriteLine("Here is as Pepperoni Pizza");
    }

    static void Main()
    {
        IPizza obj = new PepperoniPizza();
        obj.Order();
    }
}

/*
interface Test
{
    void Log();
}


class MainClass : Test
{
    void Log(string msgToPrint)
    {
        Console.WriteLine(msgToPrint);
    }

    static void Main()
    {
        Test obj = new MainClass();
    }
}
*/
