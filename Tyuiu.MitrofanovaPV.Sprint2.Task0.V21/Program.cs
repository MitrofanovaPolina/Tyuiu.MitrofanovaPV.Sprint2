﻿using Tyuiu.MitrofanovaPV.Sprint2.Task0.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 1705;
        int y = 775;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);
        Console.Title = "Спринт #2 | Выполнила: Митрофанова П.В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Митрофанова Полина Викторовна | ПИНб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("X =" + x);
        Console.WriteLine("Y =" + y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}