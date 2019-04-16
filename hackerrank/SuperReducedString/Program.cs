using System;

/*
    https://www.hackerrank.com/challenges/reduced-string/problem
*/
namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string solution = Solve(input);

            Console.WriteLine(solution);
        }

        static string Solve(string s) {
            /* 
                The code starts from the second element, and compare it to the one right before it.        
                if they are equal, take out both (since it is a match) by using substring, and assign 0 to the 
                current index so it can check again from the beginning if any more matched elements are found after the
                last exclusion.
            */
            for (int i = 1; i < s.Length; i++) {
                if (s[i] == s[i - 1]) {
                    s = s.Substring(0, i - 1) + s.Substring(i + 1);
                    i = 0;
                }
            }
            
            return s.Length == 0 ? "Empty String" : s;
        }
    }
}
