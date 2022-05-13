using System;

namespace odd
{
    class main
    {
        public void num(int a, int b, int c)
        {
            int  n = a;
            if (n < b)
            {
                n = b;
            }
            if (n < c)
            {
                n = c;
            }
            Console.WriteLine("max", +n);
        }
        public static void Main(string[] args)
        {
            int a,b,c;

            Console.WriteLine("enter num");
            a = Convert.ToInt32(Console.ReadLine());

            b = Convert.ToInt32(Console.ReadKey());
            c = Convert.ToInt32(Console.ReadKey());
            main ob = new main();
            ob.num(a,b,c);

        }
    }
}
