using System.Collections;
using Flyweight;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Drawing.Imaging;
using System;
using System.Net.Mime;


internal class Program
{
    private static void Main(string[] args)
    {

        FlyweightFactory factory = new FlyweightFactory();

        Character f1 = factory.GetFlyweight("Крош", "Воин", @"Krosh.jpg");
        f1.ChangeLevel(1);
        Character f2 = factory.GetFlyweight("Крош", "Воин", @"Krosh.jpg");
        f2.ChangeLevel(2);

        // Press enter after image pleas
        //Выведет 4 так как 1+1+2 = 4
    }
}
