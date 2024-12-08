using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GulienkoPO.Sprint6.Task2.V17.Lib
{
    public class DataService : ISprint6Task2V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue - startValue + 1];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                values[index++] = Math.Round(Math.Cos(i) + (4 * i) / 2 - Math.Sin(i) * 3 * i, 2);
            }
            return values;
        }
    }
}