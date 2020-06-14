namespace LinearDS
{
    using System;
    using LinearDS.Stacks;

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

            #region DoublyLinkedLists

            /*var doublyLinkedList = new MyDoublyLinkedList<int>();
            doublyLinkedList.AddHead(10);
            doublyLinkedList.AddHead(20);
            doublyLinkedList.AddTail(30);
            var listArray = doublyLinkedList.ToArray();
            Console.WriteLine("The Items in the Doubly Linked List are:");
            foreach (var item in listArray.AsParallel())
            {
                Console.WriteLine(item);
            }

            doublyLinkedList.Reverse();
            listArray = doublyLinkedList.ToArray();
            Console.WriteLine("The Items in the Reversed Doubly Linked List are:");
            foreach (var item in listArray.AsParallel())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"The 3rd Element from Tail is {doublyLinkedList.FindKthElementFromTail(3)}");
            doublyLinkedList.RemoveHead();
            Console.WriteLine($"The index of 30 is {doublyLinkedList.IndexOf(30)}");
            doublyLinkedList.RemoveHead();
            Console.WriteLine($"DoublyLinkedList contains 20? {doublyLinkedList.Contains(20)}");
            doublyLinkedList.RemoveTail();
            Console.WriteLine($"The Size of the Doubly Linked list is {doublyLinkedList.Size()}");*/

            #endregion

            #region Stacks

            var input = "Kasinath";
            var str = new StringReverser();
            Console.WriteLine($"The Reverse of {input} is {str.ReverseString(input)}");
            input = "((1 + 2)";
            var expression = new ExpressionBalancer();
            Console.WriteLine($"The balance of expression {input} is {expression.IsExpressionBalanced(input)}");

            var stack = new StackWithArrays<int>();
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine($"The Stack is {stack}");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            #endregion
        }
    }
}
