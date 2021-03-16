using System;

namespace dk_H_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "我的《C#课程》课本";
            string[] words = str1.Split('《', '》');
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
            string str2 = string.Join("*", words);
            Console.WriteLine(str2);
        }
    }
}
