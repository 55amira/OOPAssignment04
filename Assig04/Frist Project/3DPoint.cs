using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assig04.Frist_Project 
{
    internal class Point3D : IComparable , ICloneable
    {
        public int Ponit01 { get; set; }
        public int Ponit02 { get; set; }
        public int Ponit03 { get; set; }

        public Point3D()
        { }
       public Point3D(int p1, int p2, int p3)
        {
            Ponit01 = p1;
            Ponit02 = p2;
            Ponit03 = p3;
        }
        public override string ToString()
        {
            return $"Point Coordinates:({Ponit01},{Ponit02},{Ponit03})";
        }

        #region 6-Implement ICloneable interface to be able to clone the object.To implement more than one interface.class Point3D : IComparable, ICloneable

        public int CompareTo(object? obj)
        {
            Point3D point3D = (Point3D)obj;
            if (this.Ponit01 > point3D.Ponit01) return 1;
            else if (this.Ponit01 < point3D.Ponit01) return -1;
            else return 0;
        }

        public object Clone()
        {
            return new Point3D()
            {
                Ponit01 = this.Ponit01,
                Ponit02 = this.Ponit02,
                Ponit03 = this.Ponit03
            };
        } 
        #endregion





    }
}
