using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Краші_гірші_непорівняня_альтернатив_V2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        int[] MaxMasCret = { 3, 3, 7 };
        int[] MyMasCret = { 2, 2, 3 };
        Form1 f = new Form1();

        //тест конвертації
        [TestMethod]
        public void TestMetod_StrArrIntoIntArr()
        {

            string[] words = { "3", "3", "7" };
            CollectionAssert.AreEqual(MaxMasCret, f.StrArrIntoIntArr(words));
        }
        //тести виводу
        [TestMethod]
        public void TestMethod_StringBest()
        {
            Assert.AreEqual("Краща: (k11, k21, k31)", f.StringBest(3));
        }
        [TestMethod]
        public void TestMetod_StringWorst()
        {
            Assert.AreEqual("Гірша: (k13, k23, k37)", f.StringWorst(MaxMasCret));
        }
        //тести обчислення
        //[TestMethod]
        //public void TestMetod_CountBad()
        //{
            
        //    Assert.AreEqual(19, f.CountBad(MyMasCret, MaxMasCret));
        //}
        //[TestMethod]
        //public void TestMetod_CountGood()
        //{
            
        //    Assert.AreEqual(11, f.CountGood(MyMasCret));
        //}
        //[TestMethod]
        //public void TestMetod_CountAll()
        //{
            
        //    Assert.AreEqual(63, f.CountAll(MaxMasCret));
        //}
        //[TestMethod]
        //public void TestMetod_CountDifrent()
        //{
            
        //    Assert.AreEqual(32, f.CountDifrent(MyMasCret,MaxMasCret));
        //}

    }
}
