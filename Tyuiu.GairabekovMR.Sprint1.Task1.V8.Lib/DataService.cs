using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GairabekovMR.Sprint1.Task4.V8.Lib
{
    public class DataService : ISprint1Task4V8
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Abs(x) - Math.Abs(y);
            var res2 = Math.Sqrt(res);
            var res3 = res2 + 3 * x;
            var res4 = 3 + Math.Abs(x);
            var res5 = res3 / res4;

            return Math.Round(res5, 3);
        }
    }
}
