using System;
using System.Collections.Generic;

/*
We are given a list nums of integers representing a list compressed with run-length encoding.

Consider each adjacent pair of elements [freq, val] = [nums[2*i], nums[2*i+1]] (with i >= 0).  For each such pair, there are freq elements with value val concatenated in a sublist. Concatenate all the sublists from left to right to generate the decompressed list.

Return the decompressed list.
*/
namespace DecompressRLElist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an string with an even amount of numbers separated by a single space.");

            var inputString = Console.ReadLine();

            var intArrayInput = Array.ConvertAll(inputString.Split(" "), int.Parse);

            var intArrayResult = DecompressRLElist(intArrayInput);

            PrintArray(intArrayResult);

            Console.Read();
        }

        public static int[] DecompressRLElist(int[] nums) {
            var numsLength = nums.Length;
            var intList = new List<int>();
            
            for (var i = 0; i < numsLength - 1; i = i + 2) {
                var freq = nums[i];
                var value = nums[i+1];
                
                for (var j = 0; j < freq; j++) {
                    intList.Add(value);
                }
            }
            
            return intList.ToArray();
        }

        public static void PrintArray(int[] array) {
            Console.Write("[ ");

            foreach (var number in array) {
                Console.Write($"{number} ");
            }

            Console.Write("]");
        }
    }
}
