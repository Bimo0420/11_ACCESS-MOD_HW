using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    struct  Lineq
    {
        double a;
        double k;

        public Lineq (double a, double k)
        {
            this.a = a;
            this.k = k;
        }
        public  string Root()
        {   
            if (a == 0 && k == 0)
                return "x - любое число";
            double x = -a / k;
            return $"x = {x}";
        }
            
    }
}
