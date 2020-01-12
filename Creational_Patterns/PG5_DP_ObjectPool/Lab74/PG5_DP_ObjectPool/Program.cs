using GunGameLibrary;
using System;

namespace PG5_DP_ObjectPool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            var gun = new Gun();

            Console.WriteLine("Please press spacebar to fire and 'q' to end program.");

            var key = new ConsoleKeyInfo();
            while (key.KeyChar != 'q')
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar)
                {
                    gun.Fire();
                }
            }
        }
    }
}
