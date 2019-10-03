using MyCalcLib;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_10p20_r30()
        {
            //arrange
            int x = 10;
            int y = 20;
            int expected = 30;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Diff_30d20_r10()
        {
            //arrange
            int x = 30;
            int y = 20;
            int expected = 10;

            //act
            MyCalc c = new MyCalc();
            int actual = c.Diff(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
