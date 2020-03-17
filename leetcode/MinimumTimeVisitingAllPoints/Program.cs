using System;

/*
On a plane there are n points with integer coordinates points[i] = [xi, yi]. Your task is to find the minimum time in seconds to visit all points.

You can move according to the next rules:

    In one second always you can either move vertically, horizontally by one unit or diagonally (it means to move one unit vertically and one unit horizontally in one second).
    You have to visit the points in the same order as they appear in the array.

*/
namespace MinimumTimeVisitingAllPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCaseA = new int[][] { 
                new int[] { 1,1 }, 
                new int[] { 3, 4 }, 
                new int[] { -1,0 }
            };

            var testCaseB = new int[][] { 
                new int[] { 3, 2 }, 
                new int[] { -2, 2 }
            }; 

            var minimumTimeToVisitAllPointsA = MinTimeToVisitAllPoints(testCaseA);

            Console.WriteLine(minimumTimeToVisitAllPointsA);

            var minimumTimeToVisitAllPointsB = MinTimeToVisitAllPoints(testCaseB);

            Console.WriteLine(minimumTimeToVisitAllPointsB);
        }

        public static int MinTimeToVisitAllPoints(int[][] points) {
            var time = 0;
            
            for (var i = 0; i < points.Length - 1; i++) {
                var currentX = points[i][0];
                var currentY = points[i][1];
                var nextX = points[i + 1][0];
                var nextY = points[i + 1][1];
                
                var distanceX = Math.Abs(currentX - nextX);
                var distanceY = Math.Abs(currentY - nextY);
                
                time += Math.Max(distanceX, distanceY);
            }

            return time; 
        }
    }
}
