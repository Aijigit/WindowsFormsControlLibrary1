using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsControlLibrary1
{
    class Valuta
    {
        double res;
       public double dollAr(double dollar, double som)
        {
            res = dollar * som;
            return res;
        }
        public  double euRo(double euro, double som)
        {
            res = euro * som;
            return res;
        }
        public double Tenge(double euro, double som)
        {
            res = euro * som;
            return res;
        }
        public double Sum(double euro, double som)
        {
            res = euro * som;
            return res;
        }
    }
}
