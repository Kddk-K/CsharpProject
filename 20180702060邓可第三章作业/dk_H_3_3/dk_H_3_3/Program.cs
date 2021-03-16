using System;

namespace dk_H_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("请选择你最喜欢的游戏:A：魔兽 B:极品非常稳：C:暗黑破坏神");
            str = Console.ReadLine();
            switch (str)
            {
                case "B":
                    Console.WriteLine("你喜欢竞技体育类游戏");
                    break;
            }

        }
    }
}
