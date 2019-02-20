using System;

public class Pointer
{
    unsafe static void Main()
    {
        int m = 300;
        double fx = 300.600006;
        char cht = 'z';

        int* p = &m;
        double* p2 = &fx;
        char* p3 = &cht;

        Console.WriteLine(m);
        Console.WriteLine(fx);
        Console.WriteLine(cht);

        Console.WriteLine(*p);
        Console.WriteLine((int)&m);

        Console.WriteLine(*p2);
        Console.WriteLine((int)&fx);

        Console.WriteLine(*p3);
        Console.WriteLine((int)&cht);
    }
}