using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GairabekovMR.Sprint1.Task4.V8.Lib
{
    public class DataService : ISprint1Task4V8
    {
        public double Calculate(double x, double y)
        {
            // Формула: (-sqrt(|x - y| + 3x)) / (3 + |x|)
            double numerator = -Math.Sqrt(Math.Abs(x - y) + 3 * x);
            double denominator = 3 + Math.Abs(x);
            double result = numerator / denominator;
            return Math.Round(result, 1);
        }
    }
}


