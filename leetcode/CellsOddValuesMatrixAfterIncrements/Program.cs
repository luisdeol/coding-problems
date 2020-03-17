using System;

/*
Given n and m which are the dimensions of a matrix initialized by zeros and given an array indices where indices[i] = [ri, ci]. For each pair of [ri, ci] you have to increment all cells in row ri and column ci by 1.

Return the number of cells with odd values in the matrix after applying the increment to all indices.
*/
namespace CellsOddValuesMatrixAfterIncrements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 2;
            var m = 3;

            var testCaseIndices = new int[][] { 
                new int[] { 0, 1 }, 
                new int[] { 1, 1 }
            }; 

            var countOddsSolution = GetCountCellsOddValues(n, m, testCaseIndices);

            Console.WriteLine(countOddsSolution);
        }

        public static int GetCountCellsOddValues(int n, int m, int[][] indices) {
            var matrix = new int[n, m];
            var countOdds = 0;
            
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    matrix[i, j] = 0;
                }
            }
            
            for (var i = 0; i < indices.Length; i++) {
                var row = indices[i][0];
                var col = indices[i][1];
                
                for (var j = 0; j < m; j++) {
                    matrix[row, j]++;
                }
                
                for (var k = 0; k < n; k++) {
                    matrix[k, col]++;
                }
            }
            
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < m; j++) {
                    if (matrix[i, j] % 2 == 1) {
                        countOdds++;
                    }
                }
            }
            
            return countOdds;
        }
    }
}
