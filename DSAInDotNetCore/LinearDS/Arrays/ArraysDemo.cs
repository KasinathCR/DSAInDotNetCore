using System;

namespace LinearDS.Arrays
{
    public static class ArraysDemo
    {
        public static void Print(this Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static Array Insert(this Array arr, int item)
        {
            var arrNew = new int[arr.Length + 1];
            Array.Copy(arr, arrNew, arr.Length);
            arrNew[^1] = item;
            return arrNew;
        }
    }
}
