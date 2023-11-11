using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint4.Task5.V7.Lib;

namespace Tyuiu.SavitskyDA.Sprint4.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculte()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]
              { {-7,-6,-5,-4,-3},
                {-2,-1,1,2,3},
                {4,5,6,7,6},
                {5,4,3,2,1},
                {-1,-2,-3,-4,-5} };
            int res = ds.Calculate(matrix);
            int wait = 12;
            Assert.AreEqual(wait, res);
        }
    }
}
