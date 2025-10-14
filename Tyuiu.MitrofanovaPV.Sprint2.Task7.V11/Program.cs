using Tyuiu.MitrofanovaPV.Sprint2.Task7.V11.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите значение переменной X:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y:");
        double y = Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("Точка не находится в заштрихованной области" + res);
        }
            Console.ReadKey();
    }
}