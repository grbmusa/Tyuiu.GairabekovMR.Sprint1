using System;
using Tyuiu.GairabekovMR.Sprint1.Task7.V5.Lib;

namespace Tyuiu.GairabekovMR.Sprint1.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************** Спринт #1 | Выполнил: Гайрабеков М.Р. | ИИП6-24-2 *****************");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту *");
            Console.WriteLine("* Задание #7 *");
            Console.WriteLine("* Вариант #5 *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамазанович | ИИП6-24-2 *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем. *");
            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: *");
            Console.WriteLine("**************************************************************************************");

            double x;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************** РЕЗУЛЬТАТ: *****************");
            Console.WriteLine("**********************************************");
            Console.WriteLine(ds.Calculate(x));
            Console.WriteLine("**********************************************");
        }
    }
}

