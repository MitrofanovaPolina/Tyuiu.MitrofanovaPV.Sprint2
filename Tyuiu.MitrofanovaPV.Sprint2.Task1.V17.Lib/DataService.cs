using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MitrofanovaPV.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a>b) | (d<c);
            res[1] = (a<=b) & (d>=c);
            res[2] = (a != b) || (d<c);
            res[3] = (b<c) && (d>a);
            res[4] = !(res[1]);
            res[5] = (d>b) ^ (c != a);
            return res;
        }
    }
}
