using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Overload
{
    internal class Fraction
    {
        public int Znam { get; set; }
        public int Chisl { get; set; }
        public int Wtl { get; set; }

       public Fraction(int znam = 2, int chisl = 1, int wtl = 0)
        {
            this.Znam = znam;
            this.Chisl = chisl;
            this.Wtl = wtl;
        }
        public static Fraction operator + (Fraction a,Fraction b)
        {
            Fraction res = new Fraction();
            if (b.Znam == a.Znam)
            {
                res.Chisl = a.Chisl + (a.Znam * a.Wtl) + (b.Chisl + (b.Znam * b.Wtl));
                res.Znam = a.Znam;
            }
            else
            {
                res.Chisl = ((a.Chisl + (a.Znam * a.Wtl)) * b.Znam) + ((b.Chisl + (b.Znam * b.Wtl)) * a.Znam);

                res.Znam = a.Znam * b.Znam;
            }
            return normal(ref res);

        }
        public static Fraction operator +(Fraction a, double c)
        {
            
            Fraction res = new Fraction();
            Fraction b = new Fraction();
            string z = c.ToString();
            int poradok = 10;
            double x;
            for(int i = 1; i < z.Length; i++)
            {
                poradok *= 10;
            }
            x = c - (int)c;
            b.Chisl = (int)(x * 10); 
            b.Wtl = (int)c % poradok;
            b.Znam = 10;
            if (b.Znam == a.Znam)
            {
                res.Chisl = a.Chisl + (a.Znam * a.Wtl) + (b.Chisl + (b.Znam * b.Wtl));
                res.Znam = a.Znam;
            }
            else
            {
                res.Chisl = ((a.Chisl + (a.Znam * a.Wtl)) * b.Znam) + ((b.Chisl + (b.Znam * b.Wtl)) * a.Znam);

                res.Znam = a.Znam * b.Znam;
            }
            return normal(ref res);
        }
        public static Fraction operator - (Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            if (b.Znam == a.Znam)
            {
                res.Chisl = a.Chisl+(a.Znam * a.Wtl) - (b.Chisl +(b.Znam * b.Wtl));
                res.Znam = a.Znam;
            }
            else
            {
                res.Chisl = (a.Chisl * b.Znam) - (b.Chisl * a.Znam);
               
                res.Znam = a.Znam * b.Znam;
            }
            return normal(ref res);
        }
        public static Fraction operator * (Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            res.Chisl = (a.Chisl + (a.Znam * a.Wtl)) * (b.Chisl + (b.Znam * b.Wtl));
            res.Znam = a.Znam * b.Znam;
            return normal(ref res, a.Znam);
        }
        public static Fraction operator *(Fraction a, int c)
        {
            Fraction res = new Fraction();
            Fraction b = new Fraction();
            b.Znam = a.Znam;
            b.Wtl = c;
            res.Chisl = (a.Chisl + (a.Znam * a.Wtl)) * (b.Chisl + (b.Znam * b.Wtl));
            res.Znam = a.Znam;
            return normal(ref res, a.Znam);
        }
        public static Fraction operator *(int c, Fraction b)
        {
            Fraction res = new Fraction();
            Fraction a = new Fraction();
            a.Znam = b.Znam;
            a.Wtl = c;
            res.Chisl = (a.Chisl + (a.Znam * a.Wtl)) * (b.Chisl + (b.Znam * b.Wtl));
            res.Znam = b.Znam;
            return normal(ref res, a.Znam);
        }
        public static Fraction operator / (Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            res.Chisl = (a.Chisl + (a.Znam * a.Wtl)) * b.Znam;
            res.Znam = a.Znam * (b.Chisl + (b.Znam * b.Wtl));
            return normal(ref res, a.Znam);
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            Fraction res1 = new Fraction();
            if (a.Znam != b.Znam)
            {
                res.Znam = res1.Znam = a.Znam * b.Znam;
                res.Chisl = a.Chisl * b.Znam + (a.Wtl * res.Znam);
                res1.Chisl = b.Chisl * a.Znam + (b.Wtl * res.Znam);
            }
            else
            {
                res.Znam = res1.Znam = a.Znam;
                res.Chisl = a.Chisl + (a.Wtl * a.Znam);
                res1.Chisl = b.Chisl + (b.Wtl * b.Znam);
            }
            bool raven = res.Chisl == res1.Chisl;
            return raven;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            Fraction res1 = new Fraction();
            if (a.Znam != b.Znam)
            {
                res.Znam = res1.Znam = a.Znam * b.Znam;
                res.Chisl = a.Chisl * b.Znam + (a.Wtl * res.Znam);
                res1.Chisl = b.Chisl * a.Znam + (b.Wtl * res.Znam);
            }
            else
            {
                res.Znam = res1.Znam = a.Znam;
                res.Chisl = a.Chisl + (a.Wtl * a.Znam);
                res1.Chisl = b.Chisl + (b.Wtl * b.Znam);
            }
            bool raven = res.Chisl != res1.Chisl;
            return raven;
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            Fraction res1 = new Fraction();
            if (a.Znam != b.Znam)
            {
                res.Znam = res1.Znam = a.Znam * b.Znam;
                res.Chisl = a.Chisl * b.Znam + (a.Wtl * res.Znam);
                res1.Chisl = b.Chisl * a.Znam + (b.Wtl * res.Znam);
            }
            else
            {
                res.Znam = res1.Znam = a.Znam;
                res.Chisl = a.Chisl + (a.Wtl * a.Znam);
                res1.Chisl = b.Chisl + (b.Wtl * b.Znam);
            }
            bool raven = res.Chisl > res1.Chisl;
            return raven;
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            Fraction res = new Fraction();
            Fraction res1 = new Fraction();
            if (a.Znam != b.Znam)
            {
                res.Znam = res1.Znam = a.Znam * b.Znam;
                res.Chisl = a.Chisl * b.Znam + (a.Wtl * res.Znam);
                res1.Chisl = b.Chisl * a.Znam + (b.Wtl * res.Znam);
            }
            else
            {
                res.Znam = res1.Znam = a.Znam;
                res.Chisl = a.Chisl + (a.Wtl * a.Znam);
                res1.Chisl = b.Chisl + (b.Wtl * b.Znam);
            }
            bool raven = res.Chisl < res1.Chisl;
            return raven;
        }

        public static Fraction normal(ref Fraction a, int zname = 2)
        {
           
            while (a.Chisl > a.Znam)
            {   if (a.Chisl > 0)
                {
                    a.Chisl -= a.Znam;
                    a.Wtl += 1;
                }
                else
                {
                    a.Chisl += a.Znam;
                    a.Wtl -= 1;
                }
            }
            while (a.Znam > 100 && a.Chisl > 1)
            {
                a.Chisl /= zname;
                a.Znam /= zname;
            }
            while (a.Znam < -100 && a.Chisl < -1)
            {
                a.Chisl /= zname;
                a.Znam /= zname;
            }
            return a;
        }
        public override string ToString() {
            string drob;
            drob = this.Wtl.ToString() + "(" +this.Chisl.ToString() +"/"+ this.Znam.ToString() + ")";
            return drob;
        }
    }
}
