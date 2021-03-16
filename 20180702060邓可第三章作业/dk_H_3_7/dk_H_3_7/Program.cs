using System;

namespace dk_H_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 999999;
            Console.WriteLine("请输入第1个学员的成绩：");
            int s1 = Convert.ToInt32(Console.ReadLine());
            max = Math.Max(max, s1);
            min = Math.Min(min, s1);
            Console.WriteLine("请输入第2个学员的成绩：");
            int s2 = Convert.ToInt32(Console.ReadLine());
            max = Math.Max(max, s2);
            min = Math.Min(min, s2);
            Console.WriteLine("请输入第3个学员的成绩：");
            int s3 = Convert.ToInt32(Console.ReadLine());
            max = Math.Max(max, s3);
            min = Math.Min(min, s3);
            Console.WriteLine("请输入第4个学员的成绩：");
            int s4 = Convert.ToInt32(Console.ReadLine());
            max = Math.Max(max, s4);
            min = Math.Min(min, s4);
            Console.WriteLine("请输入第5个学员的成绩：");
            int s5 = Convert.ToInt32(Console.ReadLine());
            max = Math.Max(max, s5);
            min = Math.Min(min, s5);

            Console.WriteLine("最高分：" + max + "\t" + "最低分：" + min);
        }
    }
}
