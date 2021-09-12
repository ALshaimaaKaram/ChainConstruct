using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainConstruct
{
    class _3DPoint
    {
        //private int X, Y, Z;

        private int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                if (value > 0)
                    x = value;
                else
                    x = 1;
            }
        }

        //public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint() : this(1, 2, 3)
        {

        }

        public _3DPoint(int X) : this(X, 2, 3)
        {
            this.X = X;
        }

        public _3DPoint(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        //public void setX(int X)
        //{
        //    if (X > 0)
        //        this.X = X;
        //    else
        //        this.X = 1;
        //}

        //public void setY(int Y)
        //{
        //    if (Y > 0)
        //        this.Y = Y;
        //    else
        //        this.Y = 1;
        //}

        //public void setZ(int Z)
        //{
        //    if (Z > 0)
        //        this.Z = Z;
        //    else
        //        this.Z = 1;
        //}


        //public int getX()
        //{
        //    return this.X;
        //}

        //public int getY()
        //{
        //    return this.Y;
        //}

        //public int getZ()
        //{
        //    return this.Z;
        //}

        public void Display()
        {
            Console.WriteLine($"X is {X}, Y is {Y}, Z is {Z}");
        }

        public int CalculateDistance(_3DPoint p)
        {
            int dist;
            dist = this.X - p.X;
            return dist;
        }
    }
}
