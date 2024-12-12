using Tyuiu.GairabekovMR.Sprint1.Task4.V8.Lib;
namespace Tyuiu.GairabekovMR.Sprint1.Task4.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гайрабеков  | ИИПБ-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #1                              *");
            Console.WriteLine("* Тема: <Арифметические операции С#>                                      *");
            Console.WriteLine("*                              Задание #4                                 *");
            Console.WriteLine("*                              Вариант #8                                 *");
            Console.WriteLine("* Выполнил: Гайрабеков    | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("* Написать программу, которая отвечает всем требованиям задания.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");






            Console.Write("Введите x: ");

            double x = Convert.ToDouble(Console.ReadLine());


            Console.Write("Введите y: ");

            double y = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат: " + ds.Calculate(x, y));


            Console.ReadKey();

        }
    }
}
