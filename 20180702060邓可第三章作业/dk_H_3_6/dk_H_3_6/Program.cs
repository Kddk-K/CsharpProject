using System;

namespace dk_H_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("排序前：");
            Console.WriteLine("通用");
            Console.WriteLine("福特");
            Console.WriteLine("戴姆勒-克莱斯勒");
            Console.WriteLine("丰田");
            Console.WriteLine("大众");
            Console.WriteLine("本田");
            Console.WriteLine("日产");
            Console.WriteLine("标致");
            Console.WriteLine("菲亚特");
            Console.WriteLine("宝马");
            Console.WriteLine("****************************************");
            Console.WriteLine("排序后：");
            string[] str = {"通用", "福特", "戴姆勒-克莱斯勒", "丰田", "大众", "本田", "日产", "标致", "菲亚特", "宝马" };
            Array.Sort(str);
            foreach(string arr in str){
                Console.WriteLine(arr.ToString());
            }
            

        }
    }
}
