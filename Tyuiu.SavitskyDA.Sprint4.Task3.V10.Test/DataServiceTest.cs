using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint4.Task3.V10.Lib;

namespace Tyuiu.SavitskyDA.Sprint4.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 5, 7, 6, 6, 5 },
                                            { 5, 5, 5, 4, 6 },
                                            { 8, 5, 7, 4, 7 },
                                            { 8, 6, 7, 4, 7 },
                                            { 5, 8, 7, 8, 8 } };
            int res = ds.Calculate(matrix);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}
