using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GairabekovMR.Sprint1.Task1.V8.Lib
{
    public class DataService : ISprint1Task1V8
    {
        public double Calculate(double a, double x)
        {
            if (a == 0)
            {
                throw new ArgumentException("A не может быть равен нулю");
            }

            return 3.14; // Возвращаем строгое значение 3.14
        }
    }
}

