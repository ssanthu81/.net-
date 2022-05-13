using System;

class array
{
    int x;


    public array(int i)
    {
        x = i;
    }

    public void data()
    {
        Console.WriteLine("value of"+x);
    }






    static void main(string[] args)
    {
        array obj = new array(10);
        obj.data();

        Console.ReadLine();
        



    }
}