﻿namespace GerritTest
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Implement sanity checks
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            // this right here is obviously a very complicated calculation
            // better make someone else verify correctness
            // TODO: Implement discriminant

            var discriminant = (b * b) - (4 * a * c);
            Console.WriteLine("Discriminant is: " + discriminant);
            Console.ReadLine();
        }
    }
}
