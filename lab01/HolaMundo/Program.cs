using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, cual es tu nombre?");
            String name = Console.ReadLine();
            Console.WriteLine("Encantado de conocerte," + name + " !!!");
        }
    }
}
