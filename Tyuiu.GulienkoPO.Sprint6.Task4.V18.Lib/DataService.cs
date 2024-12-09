using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GulienkoPO.Sprint6.Task4.V18.Lib
{
    public class DataService : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass;
            int len = stopValue - startValue + 1;
            mass = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = (2 * i - 3) / (Math.Cos(i) + i) + 5;
                mass[count] = Math.Round(y, 2);
                count++;
            }
            return mass;
        }
    }
}