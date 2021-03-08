using System;

namespace dk_H_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "C#是学习.NET的基础";
            string strB = strA.Substring(2, 4);
            Console.WriteLine(strB);
        }
    }
}
