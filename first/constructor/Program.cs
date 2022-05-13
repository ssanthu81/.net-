using System;

class Par
{
    int i;

    public Par(int x)
    {
        x = i;

        Console.WriteLine("value" + x);
    }
    public void parts()
    {
        Console.WriteLine("ss"+i);
    }




    static void main(string[] args)
    {
        Par sam = new Par(10);
        Par sam2 = new Par(100);

        sam.parts();
        sam2.parts();


        Console.ReadLine();
    }
}