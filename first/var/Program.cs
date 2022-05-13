using System;

namespace var
{
    class MainClass
    {
        int x = 100;
        public static void Main(string[] args)
        {
            MainClass ss = new MainClass();
            MainClass ss2 = new MainClass();
            Console.WriteLine(ss.x+ "   " +ss2.x);
            Console.ReadLine();
        }
    }
}
