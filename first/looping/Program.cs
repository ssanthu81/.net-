using System;

namespace looping
{
    class Mains
    {
        public void rep(int m)
        {
            int i = 0;
            while (i <= m)
            {
                i = i + 2;
                Console.WriteLine("Even "+m);
                
            }
        }
        public static void Main(string[] args)
        {
            int m;
            Console.WriteLine("enter number");
            m = Convert.ToInt32(Console.ReadLine());

            Mains obj = new Mains();
            obj.rep(m);

        }
    }
}
