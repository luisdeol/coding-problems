using System;
using System.Collections.Generic;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCaseA = new int[][] { 
                new int[] { 3, 7, 8 }, 
                new int[] { 9, 11, 13 }, 
                new int[] { 15, 16, 17 }
            };

            var testCaseB = new int[][] { 
                new int[] { 1, 10, 4, 2 }, 
                new int[] { 9, 3, 8, 7 }, 
                new int[] { 15, 16, 17, 12 }
            };

            // Expected output: [15]
            var testCaseAResults = LuckyNumbers(testCaseA);
            PrintArray(testCaseAResults); 

            // Expected output: [12]
            var testCaseBResults = LuckyNumbers(testCaseB);
            PrintArray(testCaseBResults);
        }

        public static IList<int> LuckyNumbers (int[][] matrix) {
            var luckyNumbers = new List<int>();
            
            var m = matrix.Length;
            var n = matrix[0].Length;
            
            var dictionarySmallest = GetDictionarySmallestByRow(matrix);
            
            for (var i = 0; i < m; i++) {
                var colSmallest = dictionarySmallest[i];
                var biggestAtCol = true;
                    
                for (var j = 0; j < m; j++) {
                    if (matrix[j][colSmallest] > matrix[i][colSmallest]) {
                        biggestAtCol = false;
                        break;
                    }
                }
                
                if (biggestAtCol) {
                    luckyNumbers.Add(matrix[i][colSmallest]);
                }
            }
            
            return luckyNumbers;
        }
    
        public static Dictionary<int, int> GetDictionarySmallestByRow(int[][] matrix) {
            var dictionarySmallest = new Dictionary<int, int>();
            
            var m = matrix.Length;
            var n = matrix[0].Length;
            
            for (var i = 0; i < m; i++) {
                var smallest = matrix[i][0];
                var nSmallest = 0;
                
                for (var j = 0; j < n; j++) {
                    if (matrix[i][j] < smallest) {
                        smallest = matrix[i][j];
                        nSmallest = j;
                    }
                }
                
                dictionarySmallest.Add(i, nSmallest);
            }
            
            return dictionarySmallest;
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
