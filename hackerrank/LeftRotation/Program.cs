using System;

/*A left rotation operation on an array shifts each of the array's elements unit to the left. 
For example, if left rotations are performed on array , then the array would become
Given an array of integers and a number, perform left rotations on the array. 
Return the updated array to be printed as a single line of space-separated integers. */
namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayInput = new int[] { 1, 2, 3, 4, 5 };
            var rotationsToLeft = 4;

            var solution = Solve(arrayInput, rotationsToLeft);

            PrintArray(solution);
        }

        static int[] Solve(int[] a, int rotationsToLeft) {
            var rotatedArray = new int[a.Length];

            if (rotationsToLeft == a.Length)
                return a;
            
            for (var i = 0; i < a.Length; i++) {
                var remainder = rotationsToLeft % a.Length;
                int newIndex; 
                var diference = i - remainder;

                if (diference < 0) {
                    newIndex = a.Length - Math.Abs(diference);
                } else {
                    newIndex = i - rotationsToLeft;
                }

                rotatedArray[newIndex] = a[i];
            }

            return rotatedArray;
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
