
using Tyuiu.KaraschukNE.Sprint1.Task3.V11.Lib;
// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Каращук Н. Е. | ИСПб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Каращук Никита Евгеньевич | ИСПб-26-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
        Console.WriteLine("***************************************************************************");

        double x1 = -2;
        double y1 = 5;
        double x2 = 1;
        double y2 = 7;
        double x3 = 5;
        double y3 = -3;
        Console.WriteLine("Координаты угла A треугольника = " + (x1, y1));
        Console.WriteLine("Координаты угла B треугольника = " + (x2, y2));
        Console.WriteLine("Координаты угла C треугольника = " + (x3, y3));


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Площадь треугольника = " + ds.TriangleArea(x1,y1,x2,y2,x3,y3));

        Console.ReadLine();
    }
}