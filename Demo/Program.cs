using Demo.abstraction;
using Demo.Operator_Overloading;
using System.Drawing;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region abstraction
            //  Rectangle rectangle = new Rectangle() { Dim01 = 12, Dim02 = 12 };
            //
            // Console.WriteLine($"Area: {rectangle.GetArea()}");
            // Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
            //
            // Square square = new Square() { Dim01 = 1, Dim02 = 2, };
            // Console.WriteLine(square.Perimeter);
            // Console.WriteLine(square.GetArea()); 
            #endregion
            #region operator overloading
            //
            //Complex C01 = new Complex() { Real = 3, Imag = 4 };
            //Complex C02 = new Complex() {Real = 4, Imag = 5 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);
            //
            //Complex C03 = C01 + C02;
            //Console.WriteLine(C03);
            //
            //C03 = C01 - C02;
            //Console.WriteLine(C03);

            //C01++;
            //Console.WriteLine(C01);
            //
            //C01--;
            //Console.WriteLine(C01);

            //if (C01 > C02)
            //{
            //    Console.WriteLine("C01");
            //}
            //else
            //    Console.WriteLine("C02"); 
            #endregion
        }   
    }
}
