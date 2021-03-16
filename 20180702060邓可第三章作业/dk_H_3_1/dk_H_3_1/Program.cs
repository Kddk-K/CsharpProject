using System;

namespace dk_H_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个月份：");
            int month = Convert.ToInt32(Console.ReadLine());
            if((month >= 0) && (month <= 12))
            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine(month + "月属于冬季");
                        break;
                    case 2:
                        Console.WriteLine(month + "月属于冬季");
                        break;
                    case 3:
                        Console.WriteLine(month + "月属于春季");
                        break;
                    case 4:
                        Console.WriteLine(month + "月属于春季");
                        break;
                    case 5:
                        Console.WriteLine(month + "月属于春季");
                        break;
                    case 6:
                        Console.WriteLine(month + "月属于夏季");
                        break;
                    case 7:
                        Console.WriteLine(month + "月属于夏季");
                        break;
                    case 8:
                        Console.WriteLine(month + "月属于夏季");
                        break;
                    case 9:
                        Console.WriteLine(month + "月属于秋季");
                        break;
                    case 10:
                        Console.WriteLine(month + "月属于秋季");
                        break;
                    case 11:
                        Console.WriteLine(month + "月属于球季");
                        break;
                    case 12:
                        Console.WriteLine(month + "月属于东季");
                        break;
                }
            }
        }
    }
}
