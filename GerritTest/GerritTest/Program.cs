namespace GerritTest
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will go to Gerrit. Hopefully.");

            // TODO: Implement sanity checks
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            // this right here is obviously a very complicated calculation
            // better make someone else verify correctness
            // TODO: Implement discriminant
        }
    }
}
