using System;
using System.Collections.Generic;

/*
    Given an integer n, return any array containing n unique integers such that they add up to 0.
*/
namespace UniqueIntegersSumZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value.");

            var n = Convert.ToInt32(Console.ReadLine());

            var result = SumZero(n);

            PrintArray(result);
        }

        public static int[] SumZero(int n) {
            var solution = new int[n];
            
            if (n % 2 == 1) {
                var limit = n / 2;
                for (var i = 0; i < n; i++) {
                    solution[i] = (-1) * (limit - i);
                }
            } else {
                var current = 0;
                
                for (var i = 0; i < n; i++) {
                    if (i % 2 == 0) {
                        current = Math.Abs(current) + 1;
                    }
                    
                    solution[i] = current;
                    current = (-1) * current;
                }
            }
            
            return solution;
        }
        
        public static void PrintArray(IList<int> array) {
            Console.Write("[ ");

            foreach (var number in array) {
                Console.Write($"{number} ");
            }

            Console.Write("]");
        }
    }
}
