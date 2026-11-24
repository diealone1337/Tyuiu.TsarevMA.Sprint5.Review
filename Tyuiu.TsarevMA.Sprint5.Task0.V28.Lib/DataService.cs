namespace Tyuiu.TsarevMA.Sprint5.Task0.V28.Lib
{
    public class DataService
    {
        public int GetMultEvenElements(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int res = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        res *= array[i, j];
                    }
                }
            }

            return res;
        }
    }
}
