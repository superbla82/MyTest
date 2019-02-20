using System;

namespace Exercise2
{
    class MainClass
    {
        public static unsafe void Main(string[] args)
        {
            //int n = Console.Read();
            int n = 5;
            int* arr = stackalloc int[n];

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 9);
                Console.WriteLine($"Value at {i}: {arr[i]}");
            }
        }
    }
}