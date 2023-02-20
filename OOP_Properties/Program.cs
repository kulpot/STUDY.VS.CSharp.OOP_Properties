using System;

namespace OOP_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,4,5);// constructor set
            //box.length = 3;
            //box.SetLength(-4); //throw new Exception("Length should be higher than 0");
            //box.SetLength(4);
            //box.Height = -4;
            //box.Width = 5;
            Console.WriteLine("Box length is " + box.GetLength());
            //Console.WriteLine("Box's volume is " + box.GetVolume());
            Console.WriteLine("Box's volume is " + box.Volume);
            Console.WriteLine("Box's width is " + box.Width);
            box.Width = 10;
            Console.WriteLine("Box's width is " + box.Width);
            box.DisplayInfo();


        }
    }
}