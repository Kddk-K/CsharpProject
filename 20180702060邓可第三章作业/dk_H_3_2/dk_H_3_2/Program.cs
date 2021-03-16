using System;

namespace dk_H_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入车型：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入公里数：");
            int mile = Convert.ToInt32(Console.ReadLine());

            if(name == "速腾")
            {
                if(mile <= 1)
                {
                    Console.WriteLine("应付：7元");
                }
                else
                {
                    double money = 7.0 + 1.4 * (mile - 1);
                    Console.WriteLine("应付：" + money);
                }
            }

            if (name == "红旗")
            {
                if (mile <= 1)
                {
                    Console.WriteLine("应付：10元");
                }
                else
                {
                    double money = 10.0 + 1.5 * (mile - 1);
                    Console.WriteLine("应付：" + money);
                }
            }

            if (name == "捷达")
            {
                if (mile <= 1)
                {
                    Console.WriteLine("应付：5元");
                }
                else
                {
                    double money = 5.0 + 1.4 * (mile - 1);
                    Console.WriteLine("应付：" + money);
                }
            }
        }
    }
}
