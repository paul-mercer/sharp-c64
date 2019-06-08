using System;
using SharpC64;

namespace TestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Starting up");

            Frodo frodo = new Frodo();
            frodo.ReadyToRun();
            frodo.Shutdown();
            Console.Out.WriteLine("Shutting down");
        }
    }
}
