using System;
using System.Collections.Generic;

namespace QueueWithTwoStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string with whitespace-separated commands (d = dequeue, e = enqueue) ");

            var commands = Console.ReadLine().Split(" ");

            Console.WriteLine("Enter a string with whitespace-separated integer values with the same amount than commands (enter any number for dequeue) "); 

            var valuesInput = Console.ReadLine().Split(" ");

            var values = Array.ConvertAll(valuesInput, int.Parse);

            var queue = new MyQueue();

            for (var i = 0; i < commands.Length; i++) {
                if (commands[i] == "e") {
                    queue.Enqueue(values[i]);
                } else {
                    queue.Dequeue();
                }
            }

            Console.WriteLine();

            while (!queue.Empty()) {
                var current = queue.Dequeue();

                Console.Write($" {current} <- ");
            }
        }
    }

    public class MyQueue 
    {
        // s1 is used only for enqueueing.
        // s2 is used only for dequeueing. If it's empty, move all elements from s1 to s2.
        Stack<int> s1;
        Stack<int> s2;
        
        public MyQueue() {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }
        
        public void Enqueue(int x) {
            s1.Push(x);
        }
        
        public int Dequeue() {
            if (s2.Count == 0) {
                while (s1.Count > 0) {
                    s2.Push(s1.Pop());
                }
            }
            
            return s2.Pop();
        }
        
        public int Peek() {
            if (s2.Count == 0) {
                while (s1.Count > 0) {
                    s2.Push(s1.Pop());
                }
            }
            
            return s2.Peek();
        }
        
        public bool Empty() {
            return s1.Count == 0 && s2.Count == 0;
        }
    }   
}
