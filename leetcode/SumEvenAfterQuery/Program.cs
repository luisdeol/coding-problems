using System;

/* We have an array A of integers, and an array queries of queries.
    For the i-th query val = queries[i][0], index = queries[i][1], we 
    add val to A[index].  Then, the answer 
    to the i-th query is the sum of the even values of A. */
namespace SumEvenAfterQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 2, 3, 4 };
            var queries = new int[][] { 
                new int[] { 1, 0 }, 
                new int[] { -3, 1 }, 
                new int[] { -4, 0 }, 
                new int[] { 2, 3 }
            };

            var solution = Solve(input, queries);

            PrintArray(solution);
        }

        static int[] Solve(int[] A, int[][] queries) {
            var sumArray = new int[queries.Length];
            var currentSum = GetEvenNumbersSum(A);
            
            for (int i = 0; i < queries.Length; i++) {
                var index = queries[i][1];
                var value = queries[i][0];
                
                if (A[index] % 2 == 0) {
                    currentSum -= A[index];
                }
                
                A[index] += value;
                
                if (A[index] % 2 == 0) {
                    currentSum += A[index];
                }
                
                sumArray[i] = currentSum;
            }
        
            return sumArray;
        }

        static int GetEvenNumbersSum(int[] array) {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 == 0) {
                    sum += array[i];
                }
            }
        
            return sum;
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
