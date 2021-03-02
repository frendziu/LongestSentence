using System;

namespace LongestSentence
{
    class Program
    {
        static int solution(string S)
        {
            int count = 0;
            int maxCount = 0;
            string[] sentences = S.Split('.', '?', '!');
            

            foreach (string sentence in sentences)
            {
                string[] words = sentence.Split(' ');
                
                foreach(string word in words)
                {
                    if(!String.IsNullOrEmpty(word))
                    count++;
                }
                if(maxCount<count)
                maxCount = count;
                count = 0;
            }

            return maxCount;
        }

        static void Main(string[] args)
        {
            string sentence1 = "We test coders. Give us a try?";
            string sentence2 = "Forget CVs..Save time . x x";

            Console.WriteLine("The largest number of words in: " + sentence1 + " is: " + solution(sentence1));
            Console.WriteLine("The largest number of words in: " + sentence2 + " is: " + solution(sentence2));
        }
    }
}
