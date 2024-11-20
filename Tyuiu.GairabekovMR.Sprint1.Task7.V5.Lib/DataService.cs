using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GairabekovMR.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            // Формула: z = (ln|cos x|) / (ln(1 + x^2))
            double numerator = Math.Log(Math.Abs(Math.Cos(x)));
            double denominator = Math.Log(1 + x * x);
            double result = numerator / denominator;
            return Math.Round(result, 3);
        }
    }
}

