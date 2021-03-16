using System;

namespace dk_H_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cons = Convert.ToInt32(Console.ReadLine());

            if(cons >= 0121 && cons <= 0219)
            {
                Console.WriteLine("星座是水瓶座");
            }
            if (cons >= 0220 && cons <= 0320)
            {
                Console.WriteLine("星座是双鱼座");
            }
            if (cons >= 0321 && cons <= 0420)
            {
                Console.WriteLine("星座是白羊座");
            }
            if (cons >= 0421 && cons <= 0521)
            {
                Console.WriteLine("星座是金牛座");
            }
            if (cons >= 0522 && cons <= 0621)
            {
                Console.WriteLine("星座是双子座");
            }
            if (cons >= 0622 && cons <= 0722)
            {
                Console.WriteLine("星座是巨蟹座");
            }
            if (cons >= 0723 && cons <= 0823)
            {
                Console.WriteLine("星座是狮子座");
            }
            if (cons >= 0824 && cons <= 0923)
            {
                Console.WriteLine("星座是处女座");
            }
            if (cons >= 0924 && cons <= 1023)
            {
                Console.WriteLine("星座是填写座");
            }
            if (cons >= 1123 && cons <= 1221)
            {
                Console.WriteLine("星座是射手座");
            }
            if (cons >= 1223 || cons <=0120)
            {
                Console.WriteLine("星座是摩羯座");
            }

        }
    }
}
