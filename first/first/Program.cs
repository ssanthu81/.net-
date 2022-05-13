using System;

namespace first
{

    class MainClass

    {

        public void shiva()
        {
            Console.WriteLine("my name");
    }
        internal void sam()
        {
            Console.WriteLine("2nd name");
        }
        private void ss()
        {
            Console.WriteLine("3rd");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MainClass obj = new MainClass();

            obj.shiva();
            obj.sam();
            obj.ss();
        }
    }
}
