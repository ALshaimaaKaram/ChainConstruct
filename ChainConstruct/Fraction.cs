using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainConstruct
{
    class Fraction
    {
        private double numer;
        private double denom;

        //Constructor
        public Fraction() : this(9, 7)
        {

        }

        public Fraction(double numer) : this(numer, 1)
        {
            this.numer = numer;
        }

        public Fraction(double numer, double denom)
        {
            this.numer = numer;
            if (denom > 0)
                this.denom = denom;
            else
                this.denom = 1;
        }

        public void setNumer(double numer)
        {
            this.numer = numer;
        }

        public void setDenom(double denom)
        {
            if (denom > 0)
                this.denom = denom;
            else
                denom = 1;
        }

        public double getNumer()
        {
            return numer;
        }

        public double getDenom()
        {
            return denom;
        }


        public void Display()
        {
            Console.WriteLine($"The Fraction is {numer} / {denom}");
        }

        public Fraction Add(Fraction f)
        {
            Fraction res = new Fraction();
            res.numer = this.numer * f.denom + f.numer * this.denom;
            res.denom = this.denom * f.denom;
            return res;
        }

        //public Fraction Add(Fraction f1, Fraction f2)
        //{
        //    Fraction res = new Fraction();
        //    res.numer = f1.numer * f2.denom + f2.numer * f1.denom;
        //    res.denom = f1.denom * f2.denom;
        //    return res;
        //}
    }
}
