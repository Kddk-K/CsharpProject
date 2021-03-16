using System;

namespace dk_H_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入月份：");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入座位类别：（1、头等舱 2、经济舱）");
            int i = Convert.ToInt32(Console.ReadLine());

            double price;
            if(month >= 5 && month <= 10)
            {
                if(i == 1)
                {
                    price = 4000 * 0.9;
                    Console.WriteLine("机票价格为：" + price);
                }
                if(i == 2)
                {
                    price = 4000 * 0.75;
                    Console.WriteLine("机票价格为：" + price);
                }
            }
            else
            {
                if (i == 1)
                {
                    price = 4000 * 0.6;
                    Console.WriteLine("机票价格为：" + price);
                }
                if (i == 2)
                {
                    price = 4000 * 0.3;
                    Console.WriteLine("机票价格为：" + price);
                }
            }
        }
    }
}
