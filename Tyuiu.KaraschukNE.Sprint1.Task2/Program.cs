using Tyuiu.KaraschukNE.Sprint1.Task2.V20.Lib;
// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Каращук Н. Е. | ИСПб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнил: Каращук Никита Евгеньевич | ИСПб-26-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");


        int x, y;
        Console.WriteLine("Введите значение X;");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение Y;");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.CalculateSquaresSumm(x, y));

        Console.ReadLine();
    }
}