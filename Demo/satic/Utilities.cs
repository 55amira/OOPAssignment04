using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.satic
{
    internal static class Utilities
    {

        //public  int X { get; set; }
        //public int Y { get; set; }
        
        private static double Pi;

        static Utilities() 
        {
            Pi=3.14;
        }
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        public static double PI
        {
            get { return Pi; }
        }
    }
}
