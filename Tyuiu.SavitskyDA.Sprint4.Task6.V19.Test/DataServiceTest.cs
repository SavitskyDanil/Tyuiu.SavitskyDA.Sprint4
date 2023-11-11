using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint4.Task6.V19.Lib;

namespace Tyuiu.SavitskyDA.Sprint4.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var array = new string[] { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };
            int res = ds.Calculate(array);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
