using System;
using Autoclickerro.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ClickLimitTest()
        {
            test1.start(5);
            Console.ReadKey();
            
        }
    }
}
