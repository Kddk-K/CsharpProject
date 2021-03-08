using System;

namespace dk_H_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("请输入你的语文成绩：");
            string cn = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩：");
            string math = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩：");
            string en = Console.ReadLine();
            Console.WriteLine("你的平均成绩是：" + (int.Parse(cn)+int.Parse(math)+int.Parse(en))/3);
        }
    }
}
