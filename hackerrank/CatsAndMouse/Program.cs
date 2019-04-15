using System;

/*
    https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
*/
namespace CatsAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new string[2] {
                "1 2 3",
                "1 3 2"
            };

            for (int i = 0; i < input.Length; i++) {
                var inputValuesArray = Array.ConvertAll(input[i].Split(" "), n => Convert.ToInt32(n));
                var catAPosition = inputValuesArray[0];
                var catBPosition = inputValuesArray[1];
                var mousePosition = inputValuesArray[2];
                
                var solution = Solve(catAPosition, catBPosition, mousePosition);

                Console.WriteLine(solution);
            }
        }

        static string Solve(int x, int y, int z) {
            var distanceCatAfromMouse = Math.Abs(z - x);
            var distanceCatBfromMouse = Math.Abs(z - y);

            if (distanceCatAfromMouse == distanceCatBfromMouse) {
                return "Mouse C";
            } else if (distanceCatAfromMouse < distanceCatBfromMouse) {
                return "Cat A";
            } else {
                return "Cat B";
            }
        }
    }
}
