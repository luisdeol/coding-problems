using System;
using System.Collections.Generic;
using System.Linq;

/*
    Given an array arr, replace every element in that array with the greatest element among the elements to its right, and replace the last element with -1.

    After doing so, return the array.
*/
namespace ReplaceElementsWithGreatestOnRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an string from 1 to 10000 numbers separated by a single space between each other. Each number should range from 0 to 10000.");

            var inputString = Console.ReadLine();

            var intArrayInput = Array.ConvertAll(inputString.Split(" "), int.Parse);

            var replacedElementsArray = ReplaceElements(intArrayInput);

            PrintArray(replacedElementsArray);
        }

        public static int[] ReplaceElements(int[] arr) {
            var biggest = arr.Max();
            
            for (var i = 0; i < arr.Length - 1; i++) {
                if (arr[i] == biggest) {
                    var toSkip = i + 1;
                    biggest = (arr.Skip(toSkip).Take(arr.Length - toSkip)).Max();
                }
                
                arr[i] = biggest;
            }
            
            arr[arr.Length - 1] = -1;
            
            return arr;
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
