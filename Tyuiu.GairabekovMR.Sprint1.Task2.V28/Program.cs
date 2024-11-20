using System;

namespace Tyuiu.GairabekovMR.Sprint1.Task2.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Гайрабеков М.Р. | ИИПб-24-2";
            Console.WriteLine("***********************************************");
            Console.WriteLine("* Спринт #1                                   *");
            Console.WriteLine("* Тема: Аритметические операторы в C#         *");
            Console.WriteLine("* Задание #2                                  *");
            Console.WriteLine("* Вариант #28                                 *");
            Console.WriteLine("* Выполнил: Гайрабеков Муса Рамзанович | ИИПб-24-2 *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("* УСЛОВИЕ:                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает     *");
            Console.WriteLine("* у пользователя исходные данные,             *");
            Console.WriteLine("* выполняет указанные расчёты и печатает      *");
            Console.WriteLine("* результат на экране.                        *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                            *");
            Console.WriteLine("***********************************************");

            // Запрашиваем у пользователя температуру в градусах Цельсия
            Console.Write("Введите температуру в градусах Цельсия: ");
            int celsius = int.Parse(Console.ReadLine());

            // Переводим температуру в градусы Кельвина
            int kelvin = ConvertCelsiusToKelvin(celsius);

            // Печатаем результат
            Console.WriteLine("Температура в градусах Кельвина: " + kelvin);
        }

        static int ConvertCelsiusToKelvin(int celsius)
        {
            return celsius + 273;
        }
    }
}





