using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula

{
    class FormulaMatematica
    {
        public static double Formula(int a, int n)
        {
            double total = 0;
            double cal = 0;
            for(int t=a; t<=n; t++)
            {
                cal += ((Math.Pow(2, t + 1)) - (Math.Pow(2, t))) / (t +1);
            }
            total = total + cal;


            return total;
        }
    }
}
