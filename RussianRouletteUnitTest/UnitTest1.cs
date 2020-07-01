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
            
                try
                {
                    Logic.ShootAway();
                    Assert.IsTrue(true);
                }
                catch
                {
                    Assert.IsTrue(false);
                }

            
        }
        [TestMethod]
        public void ShootAtHeadTest()
        {

            try
            {
                Logic.ShootAtHead();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }


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


    

