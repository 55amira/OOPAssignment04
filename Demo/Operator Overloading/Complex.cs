using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public static Complex operator +(Complex Right, Complex Left)
        {
            return new Complex()
            {
                Real = (Right?.Real ?? 0) + (Left?.Real ?? 0),
                Imag = (Right?.Imag ?? 0) + (Left?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex Right, Complex Left)
        {
            return new Complex()
            {
                Real = (Right?.Real ?? 0) - (Left?.Real ?? 0),
                Imag = (Right?.Imag ?? 0) - (Left?.Imag ?? 0)
            };
        }

        public static Complex operator ++(Complex complex)
        {
            if (complex != null)
            {
                complex.Real++;
                complex.Imag++;
                return complex;
            }
            return new Complex();
        }

        public static Complex operator --(Complex complex)
        {
            if (complex != null)
            {
                complex.Real--;
                complex.Imag--;
                return complex;
            }
            return new Complex();
        }

        public static bool operator > (Complex Right, Complex Left)
        {
            if (Right.Real == Left.Real)
            {
                return Right.Imag>Left.Imag;
            }
            return Right.Real > Left.Real;
                

        }
            

        public static bool operator <(Complex Right, Complex Left)
        {

            if (Right.Real == Left.Real)
            {
                return Right.Imag < Left.Imag;
            }
            return Right.Real < Left.Real;

        }
        public static bool operator >=(Complex Right, Complex Left)
        {
            if (Right.Real == Left.Real)
            {
                return Right.Imag > Left.Imag;
            }
            return Right.Real > Left.Real;


        }


        public static bool operator <=(Complex Right, Complex Left)
        {

            if (Right.Real == Left.Real)
            {
                return Right.Imag < Left.Imag;
            }
            return Right.Real < Left.Real;

        }

        public static bool operator ==(Complex Right, Complex Left)
        { 
          return (Right.Real == Left.Real) && (Right.Imag == Left.Imag);
        }
        public static bool operator !=(Complex Right, Complex Left)
        {
            return (Right.Real != Left.Real) || (Right.Imag != Left.Imag);
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
