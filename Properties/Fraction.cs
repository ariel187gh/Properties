using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Fraction : IComparable
    {
        private int numerator;
        public int Numerator { get; set; }

        private int denominator;
        public int Denominator { get { return denominator; } set { if (value != 0) { denominator = value; } } }


        int CompareTo(object other) 
        {
            double num = this.numerator / (double)denominator;
            Fraction f=other as Fraction;
            if (f == null)
            {
                return 2;
            }
            double num2= f.numerator/(double)denominator;
            //השלמה
            return 0;

        }
        









    }
}
