using System;
using LinearDS.Arrays;

namespace LinearDS
{
    internal static class Program
    {
        private static void Main()
        {
            //Extension Methods for Array Logic
            Console.WriteLine("Extension Method for System.Array Class Approach:");
            int[] arr = { 10, 20, 30 };
            arr = (int[])arr.Insert(40);
            arr.Print();

            //Simple Custom Array Class Logic
            Console.WriteLine("Custom Array Class Approach:");
            var myArray = new MyArray<int>(3);
            myArray.Insert(3);
            myArray.Insert(4);
            myArray.Insert(5);
            myArray.Insert(6);
            myArray.Insert(7);
            myArray.Print();
            myArray.RemoveAt(3);
            /*myArray.RemoveAt(7);*/ //Throws Exception which is expected
            myArray.Print();
            Console.WriteLine($"Index of Item 7 is: {myArray.IndexOf(7)}");

            Console.ReadKey();
        }
    }
}
