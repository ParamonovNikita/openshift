using System;
using System.Threading;

namespace OpenShiftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello OpenShift .net core!!!");
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Running...");
            }
        }
    }
}
