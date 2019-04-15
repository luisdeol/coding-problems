using System;

/*Given a string, you need to reverse the order of characters in each word within a
 sentence while still preserving whitespace and initial word order. */
namespace ReverseWordsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Let's take LeetCode contest";

            var solution = Solve(input);

            Console.WriteLine(solution);
        }

        static string Solve(string word) {
            var words = word.Split();
        
            for (int i = 0; i < words.Length; i++) {
                var charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                
                words[i] = new string(charArray);
            }
            
            return string.Join(" ", words);
        }
    }
}
