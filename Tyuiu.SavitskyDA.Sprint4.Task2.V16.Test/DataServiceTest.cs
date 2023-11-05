using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint4.Task2.V16.Lib;

namespace Tyuiu.SavitskyDA.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 5, 5 };
            int res = ds.Calculate(array);
            int wait = 34;
            Assert.AreEqual(wait, res);
        }
    }
}
