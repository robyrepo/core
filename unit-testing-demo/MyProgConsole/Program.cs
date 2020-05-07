using System;
using PrimeService;
namespace MyProgConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new  PrimeServiceClass();
            Console.WriteLine(s.IsPrime(1));
        }
    }
}
