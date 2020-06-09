namespace LinearDS
{
    using System;
    using LinearDS.LinkedLists;

    internal static class Program
    {
        private static void Main()
        {
            #region Arrays

            //Extension Methods for Array Logic
            /*Console.WriteLine("Extension Method for System.Array Class Approach:");
            int[] arr = { 10, 20, 30 };
            arr = (int[])arr.Insert(40);
            arr.Print();*/

            //Simple Custom Array Class Logic
            /*Console.WriteLine("Custom Array Class Approach:");
            var myArray = new MyArray<int>(3);
            myArray.Insert(3);
            myArray.Insert(4);
            myArray.Insert(5);
            myArray.Insert(6);
            myArray.Insert(7);
            myArray.Print();
            myArray.RemoveAt(3);
            myArray.RemoveAt(7); //Throws Exception which is expected
            myArray.Print();
            Console.WriteLine($"Index of Item 7 is: {myArray.IndexOf(7)}");*/

            #endregion

            #region LinkedLists

            /*var list = new MyLinkedList<int>();
            list.AddTail(10);
            list.AddTail(20);
            list.AddTail(30);
            list.AddHead(5);
            Console.WriteLine(list.IndexOf(30));
            Console.WriteLine(list.IndexOf(500));
            Console.WriteLine(list.Contains(30));
            Console.WriteLine(list.Contains(500));
            Console.WriteLine($"The Size of LinkedList is {list.Size()}");
            list.RemoveHead();
            list.RemoveTail();
            Console.WriteLine($"The Size of LinkedList is {list.Size()}");
            var linkedListItems = list.ToArray();
            Console.WriteLine("The Items in the Linked List are:");
            Array.ForEach(
                linkedListItems,
                Console.WriteLine);
            list.Reverse();
            linkedListItems = list.ToArray();
            Console.WriteLine("The Items in the Reversed Linked List are:");
            Array.ForEach(
                linkedListItems,
                Console.WriteLine);
            Console.WriteLine(list.FindKthItemFromTail(0));*/

            #endregion

            #region DoublyLinkedList

            var doublyLinkedList = new MyDoublyLinkedList<int>();
            doublyLinkedList.AddHead(10);
            doublyLinkedList.AddHead(20);
            doublyLinkedList.AddTail(30);

            #endregion
        }
    }
}
