using System;

namespace posrneg
{
    class main
    {
        public void add(int n)
        {
            if(n >= 0)
            {
                Console.WriteLine("pos");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter num");

            main neww = new main();
            neww.add(n);

            
        }
    }
}
