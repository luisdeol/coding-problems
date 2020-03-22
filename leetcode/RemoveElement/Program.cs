using System;
using System.Collections.Generic;
using System.Linq;

/*
    Given an array nums and a value val, remove all instances of that value in-place and return the new length.

    Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

    The order of elements can be changed. It doesn't matter what you leave beyond the new length.
*/
namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an string from 1 to 10000 numbers separated by a single space between each other.");

            var inputString = Console.ReadLine();

            var numbersArray = Array.ConvertAll(inputString.Split(" "), int.Parse);

            Console.WriteLine("Enter the value to be removed from the array.");

            var value = Convert.ToInt32(Console.ReadLine());

            var solutionLength = RemoveElement(numbersArray, value);

            PrintArray(numbersArray.Take(solutionLength).ToList());
        }

        public static int RemoveElement(int[] nums, int val) {
            if (nums.Length == 0) {
                return 0;
            }
            
            Array.Sort(nums);
            
            var indexOf = Array.IndexOf(nums, val);
            var lastIndexOf = Array.LastIndexOf(nums, val);
            var quantity = lastIndexOf - indexOf + 1;
            
            if (indexOf == -1) {
                return nums.Length;    
            }
            
            var head = lastIndexOf + 1;
            
            while (head <= nums.Length - 1) {
                nums[indexOf] = nums[head];
                head++;
                indexOf++;
            }
            
            return indexOf;
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
