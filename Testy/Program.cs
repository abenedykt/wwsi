using System;

namespace Testy
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var result = f(x, y);
            Console.WriteLine(result);
        }

        private static int f(int x, int y)
        {
            return x + y;
        }
    }
}
