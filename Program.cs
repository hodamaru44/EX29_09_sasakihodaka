using System;

namespace EX29_09_sasakihodaka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"boxの体積={Box.GetVolume(1, 3.5f, 2)},Boxの表面積＝{Box.GetSurface(1, 3.5f, 2)}");
        }
    }
}
