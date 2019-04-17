using System;
using System.Collections.Generic;

/*
    https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
*/
namespace HackerRankInString
{
    class Program
    {
        static void Main(string[] args)
        {  
            int amountOfQueries = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amountOfQueries; i++) {
                string stringToBeSearched = Console.ReadLine();

                string solution = Solve(stringToBeSearched);
                
                Console.WriteLine(solution);
            }
        }

        static string Solve(string s) {
            var hackerrank = "hackerrank";
            var queue = new Queue<int>();

            for (int i = 0; i < hackerrank.Length; i++) {
                queue.Enqueue((int)hackerrank[i]);
            }

            for (int i = 0; i < s.Length && queue.Count > 0; i++) {
                if (queue.Peek() == (int)s[i]) {
                    queue.Dequeue();
                }
            }

            return queue.Count == 0 ? "YES" : "NO";
        }
    }
}
