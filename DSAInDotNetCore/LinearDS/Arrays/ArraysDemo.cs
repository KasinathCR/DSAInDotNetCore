using System;

namespace LinearDS.Arrays
{
    public static class ArraysDemo
    {
        //Run-time Complexity = O(n)
        public static void Print(this Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        //Run-time Complexity = O(n)
        public static Array Insert(this Array arr, int item)
        {
            var arrNew = new int[arr.Length + 1];
            Array.Copy(arr, arrNew, arr.Length);
            arrNew[^1] = item;
            return arrNew;
        }
    }
}
