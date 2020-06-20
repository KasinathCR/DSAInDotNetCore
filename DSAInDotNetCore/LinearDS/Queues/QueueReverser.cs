using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq.Extensions;

namespace LinearDS.Queues
{
    public class QueueReverser<T>
    {
        public void ReverseQueue(Queue<T> queue)
        {
            var stack = new Stack<T>();

            while (queue.TryDequeue(out var result))
            {
                stack.Push(result);
            }

            while (stack.TryPop(out var result))
            {
                queue.Enqueue(result);
            }

            Console.WriteLine("The reversed contents of queue are:");
            queue.AsParallel().ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}