using System;
using System.Collections.Generic;

/*Given a list of numbers and a number k, return whether any two numbers from the list add up to k. */
namespace daily_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 10, 15, 3, 7 };
            var k = 17;

            var solution = Solve(input, k);

            Console.WriteLine(solution);
        }

        static bool Solve(int[] array, int k) {
            var set = new HashSet<int>();
            
            for (int i = 0; i < array.Length; i++) {
                if (set.Contains(array[i])) {
                    return true;
                }

                set.Add(k - array[i]);
            }

            return false;
        }
    }
}
