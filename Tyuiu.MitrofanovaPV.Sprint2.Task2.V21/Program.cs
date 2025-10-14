using Tyuiu.MitrofanovaPV.Sprint2.Task2.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        
        Console.Title = "Спринт #2 | Выполнила: Митрофанова П.В. | ПИНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if                                                       *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Митрофанова Полина Викторовна | ПИНб-25-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение переменной X:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y:");
        int y = Convert.ToInt32(Console.ReadLine());
        bool res = ds.CheckDotInShadedArea(x, y);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }
        Console.ReadKey();
    }
}