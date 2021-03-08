using System;

namespace dk_H_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "good good study!day day up";
            Console.WriteLine(s1);
            char[] c1 = s1.ToCharArray();
            for(int i = 0; i < c1.Length; i++)
            {
                if(c1[i] == '!')
                {
                    c1[i] = ',';
                }
            }
            string s2 = new string(c1);
            Console.WriteLine(s2);

            string s3 = s1.Replace("good", "better");
            Console.WriteLine(s3);
        }
    }
}
