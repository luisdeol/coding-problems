using System;
using System.Collections.Generic;

/*
For a non-negative integer X, the array-form of X is an array of its digits in left to right order.  For example, if X = 1231, then the array form is [1,2,3,1].

Given the array-form A of a non-negative integer X, return the array-form of the integer X+K.
*/
namespace AddToArrayForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an string from 1 to 10000 numbers separated by a single space between each other.");

            var inputString = Console.ReadLine();

            Console.WriteLine("Enter K: ");

            var k = Console.ReadLine();

            var intArrayInput = Array.ConvertAll(inputString.Split(" "), int.Parse);

            var listResult = AddToArrayForm(intArrayInput, int.Parse(k));

            PrintArray(listResult);
        }

        public static IList<int> AddToArrayForm(int[] A, int K) {
            var carry = K;
            var i = A.Length;
            var digitsList = new List<int>();
            
            while (--i >= 0 || carry > 0) {
                if (i >= 0) {
                    carry += A[i];
                }
                
                digitsList.Add(carry % 10);
                
                carry = carry / 10;
            }
            
            digitsList.Reverse();
            
            return digitsList;
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
