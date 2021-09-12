using System;

namespace ChainConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            _3DPoint p1 = new _3DPoint(1,2,3);
            p1.X = 5;
            p1.Y = 6;
            p1.Z = 3;

            p1.Display();

            //_3DPoint p2 = new _3DPoint(1, 6, 4);
            //p2.Display();


            //Console.WriteLine("this dist is " + p1.CalculateDistance(p2));


            ////////////**************************//////////////////////
            //Fraction f1 = new Fraction(5);
            //f1.Display();


            //Fraction f2 = new Fraction(1, 2);
            //f2.Display();

            //Fraction f3 = new Fraction();
            //f3 = f1.Add(f2);
            //Console.WriteLine("The addition is " + f3.getNumer() + "/" + f3.getDenom());
        }
    }
}
