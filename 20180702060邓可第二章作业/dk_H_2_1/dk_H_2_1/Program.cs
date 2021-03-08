using System;

namespace dk_H_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("报名信息填写：");
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("render:");
            string render = Console.ReadLine();
            Console.WriteLine("age:");
            string age = Console.ReadLine();
            Console.WriteLine("talent:");
            string talent = Console.ReadLine();

            Console.WriteLine("您报名的填写个人信息是：");
            Console.WriteLine("name" + "\t"+ "render" + "\t" + "age" + "\t" + "talent");
            Console.WriteLine(name + "\t" + render + "\t" + age + "\t" + talent);
        }
    }
}
