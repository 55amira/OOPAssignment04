﻿using Assig04.Frist_Project;
using System.Drawing;
using System.Net;

namespace Assig04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region 2-Override the ToString Function to produce this output:Point3D P = new Point3D(10, 10, 10);Console.WriteLine(P.ToString())Output: “Point Coordinates: (10, 10, 10)”.

            //Point3D P = new Point3D(10, 10, 10);
            //
            //Console.WriteLine(P); 
            #endregion

            
            #region 3-Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares
            //Point3D P1 = new Point3D();

            //Point3D P2 = new Point3D();


            //int X, Y, Z ,A,B,C;
            //do
            //{
            //    Console.WriteLine ("Enter Point01  : ");

            //} while (!int.TryParse(Console.ReadLine(), out  X ) ||! int.TryParse(Console.ReadLine(), out Y)||! int.TryParse(Console.ReadLine(), out Z));

            //do
            //{
            //    Console.WriteLine("Enter Point02  : ");

            //} while (!int.TryParse(Console.ReadLine(), out A) || !int.TryParse(Console.ReadLine(), out B) || !int.TryParse(Console.ReadLine(), out C));


            //P1.Ponit01 = X;
            //P1.Ponit02= Y;
            //P1.Ponit03= Z;

            //P2.Ponit01= A;
            //P2.Ponit02= B;
            //P2.Ponit03= C;

            //Console.WriteLine(P1);
            //Console.WriteLine(P2); 
            #endregion


            #region 4- Try to use ==If(P1 == P2)   Does it work properly? 

            //If(P1 == P2) // No 
            #endregion


            #region 5-Define an array of points and sort this array based on X & Y coordinates.
            Point3D[] point3D = new Point3D[3]
            {
                new Point3D(100,2,3),
                new Point3D(50,5,6),
                new Point3D(1,8,9),
            };

            Array.Sort(point3D);

            foreach (Point3D p in point3D)
            {
                Console.WriteLine(p);
            }
            #endregion






        }
    }
}
