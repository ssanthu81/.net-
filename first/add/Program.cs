using System;

namespace add
{
    class MainsClass

    {
        public int x = 100;

        }

    class second
    {

        static void main(String[] args)
        {
            MainsClass obj = new MainsClass();
            MainsClass obj1 = new MainsClass();
            MainsClass obj2 = new MainsClass();

            Console.WriteLine(obj.x + " " + obj1.x + "  " + obj2.x);

            Console.ReadLine();

        }



    }



    }

