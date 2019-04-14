using System;

/*
    Given an array of integers, return a new array such that each element at index i of the new array 
    is the product of all the numbers in the original array except the one at i.
 */
namespace daily_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[5] { 1, 2, 3, 4, 5 };

            var solution = Solve(input);

            PrintArray(solution);
        }

        static int[] Solve(int[] array) {
            var newArray = new int[array.Length];
            var totalProduct = 1;

            for (int i = 0; i < array.Length; i++) {
                totalProduct *= array[i];
            }

            for (int i = 0; i < newArray.Length; i++) {
                newArray[i] = totalProduct / array[i];
            }

            return newArray;
        }

        static void PrintArray(int[] array) {
            Console.Write("[ ");
            for (int i = 0; i < array.Length; i++) {
                Console.Write($"{array[i]}");

                if (i != array.Length - 1) {
                    Console.Write(", ");
                }
            }
            
            Console.Write(" ]\n");
        }
    }
}
