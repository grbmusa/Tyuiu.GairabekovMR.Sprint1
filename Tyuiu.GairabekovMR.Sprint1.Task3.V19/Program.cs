using Tyuiu.GairabekovMR.Sprint1.Task3.V19.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Гайрабеков М.Р. | ИИПб-24-2";
            Console.WriteLine("***********************************************");
            Console.WriteLine("* Спринт #1                                   *");
            Console.WriteLine("* Тема: Операторы составного присваивания     *");
            Console.WriteLine("* Задание #3                                  *");
            Console.WriteLine("* Вариант #19                                 *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамазанович | ИИПб-24-2 *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("* УСЛОВИЕ:                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает     *");
            Console.WriteLine("* у пользователя исходные данные,             *");
            Console.WriteLine("* выполняет указанные расчёты и печатает      *");
            Console.WriteLine("* результат на экране.                        *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                            *");
            Console.WriteLine("***********************************************");

            // Запрашиваем у пользователя координаты первого поля
            Console.Write("Введите координату x1 (от 1 до 8): ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату y1 (от 1 до 8): ");
            double y1 = double.Parse(Console.ReadLine());

            // Запрашиваем у пользователя координаты второго поля
            Console.Write("Введите координату x2 (от 1 до 8): ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите координату y2 (от 1 до 8): ");
            double y2 = double.Parse(Console.ReadLine());

            // Проверяем, может ли слон перейти с одного поля на другое за один ход
            bool canBishopMove = ElephCanMove(x1, y1, x2, y2);

            // Печатаем результат
            Console.WriteLine("Слон может перейти с (" + x1 + ", " + y1 + ") на (" + x2 + ", " + y2 + "): " + canBishopMove);
        }

        static bool ElephCanMove(double x1, double y1, double x2, double y2)
        {
            // Слон может двигаться по диагоналям, то есть разница по x должна быть равна разнице по y
            return Math.Abs(x1 - x2) == Math.Abs(y1 - y2);
        }
    }
}

