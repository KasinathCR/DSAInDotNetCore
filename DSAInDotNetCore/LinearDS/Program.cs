using System;
using LinearDS.Arrays;

namespace LinearDS
{
    internal static class Program
    {
        private static void Main()
        {
            int[] arr = { 10, 20, 30 };
            arr = (int[])arr.Insert(40);
            arr.Print();
            Console.ReadKey();
        }
    }
}
