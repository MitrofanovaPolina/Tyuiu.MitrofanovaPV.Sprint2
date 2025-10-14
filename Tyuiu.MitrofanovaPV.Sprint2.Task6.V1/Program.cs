using Tyuiu.MitrofanovaPV.Sprint2.Task6.V1.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите номер месяца:");
        int value = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество дней =" + ds.FindMonthDaysCount(value));
        Console.ReadKey();
    }
}