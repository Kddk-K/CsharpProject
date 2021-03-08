using System;

namespace dk_H_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码：");
            string pass = Console.ReadLine();
            string massage = (name == "C#") && (pass == "software 1001") ? success() : fail();
            Console.WriteLine(massage);

        }
        static string success()
        {
            return "登录成功";
        }
        static string fail()
        {
            return "登录失败";
        }
    }
}
