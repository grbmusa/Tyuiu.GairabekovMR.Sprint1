using Tyuiu.GairabekovMR.Sprint1.Task4.V8.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task4.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Гайрабеков М.Р. | ИИПб-2ч-2";
            Console.WriteLine("*********************************************************");
            Console.WriteLine("* Спринт #1                                             *");
            Console.WriteLine("* Тема: Class Math                                      *");
            Console.WriteLine("* Задание #4                                            *");
            Console.WriteLine("* Вариант #8                                            *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамазанович | ИИПб-2ч-2     *");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                              *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя*");
            Console.WriteLine("* исходные данные, выполняет расчёт и печатает результат*");
            Console.WriteLine("* на экране.                                            *");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                      *");
            Console.WriteLine("*********************************************************");

            // Запрашиваем у пользователя значения x и y
            double x, y;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            // Выполнение расчётов с использованием метода Calculate
            double result = ds.Calculate(x, y);

            // Округление результата до трёх знаков после запятой
            result = Math.Round(result, 3);

            Console.WriteLine("*********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                            *");
            Console.WriteLine("*********************************************************");
            Console.WriteLine(result);
        }
    }
}

