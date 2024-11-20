using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.GairabekovMR.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double y1, double x2, double y2)
        {
            // Слон может двигаться по диагоналям, то есть разница по x должна быть равна разнице по y
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }
    }
}

