using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RussianRoulette;

namespace RussianRouletteUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        RussianRouletteClass Logic = new RussianRouletteClass();

        [TestMethod]
        public void ShootAwayTest()
        {

            Logic.ShootAwayChances = 2;

            int Expected = 2;
            int Actual = Logic.ShootAwayChances;

            Assert.AreEqual(Expected, Actual);

        }
      
        [TestMethod]
        public void SpinTest()
        {

            try
            {
                Logic.Spin();
               
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }


        }
    }
}


    

