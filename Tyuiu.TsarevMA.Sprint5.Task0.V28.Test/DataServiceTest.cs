using Tyuiu.TsarevMA.Sprint5.Task0.V28.Lib;
namespace Tyuiu.TsarevMA.Sprint3.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalc()
        {
            DataService ds = new DataService();

            string str = "623351179845632";
            int[,] array = new int[5, 3];
            int index = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = int.Parse(str[index].ToString());
                    index++;
                }
            }

            int res = ds.GetMultEvenElements(array);
            int wait = 4608;

            Assert.AreEqual(wait, res);
        }
    }
}