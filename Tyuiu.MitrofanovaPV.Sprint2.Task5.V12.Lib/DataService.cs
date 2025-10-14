using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MitrofanovaPV.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int day = n;
            int month = m;
            int year = g;
            if (day >1)
            {
                day--;
            }
            else
            {
                month --;
                if (month ==0)
                {
                    month = 12;
                    year--;
                }
                int daysinprevmonth = 0;

                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        daysinprevmonth = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        daysinprevmonth = 30;
                        break;
                    case 2:
                        daysinprevmonth = 29;
                        break;

                }
                day = daysinprevmonth;
                
            }
            return $"{day:D2}.{month:D2}.{year}";
        }
    }
}
