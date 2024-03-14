using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Краші_гірші_непорівняня_альтернатив_V2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        static int NMasCret = 3;
        static int[] MaxMasCret = { 3, 3, 7 };
        static int[] MyMasCret = { 2, 2, 3 };
        Calculation MyCalc = new Calculation(NMasCret, MaxMasCret, MyMasCret);

        //тест конвертації
       [TestMethod]
        public void TestMetod_StrArrIntoIntArr()
        {
            StrInputData f=new StrInputData("3", "3 3 7", "2 2 3");
            CollectionAssert.AreEqual(MaxMasCret, f.StrArrIntoIntArr(f.StrMaxMasCret));
        }
        //тести виводу
        [TestMethod]

        public void TestMethod_StringBest()
        {
            Assert.AreEqual("Краща: (k11, k21, k31)", MyCalc.StringBest());
        }
        [TestMethod]
        public void TestMetod_StringWorst()
        {
            Assert.AreEqual("Гірша: (k13, k23, k37)", MyCalc.StringWorst());
        }
        //тести обчислення
        [TestMethod]
        public void TestMetod_CountBad()
        {

            Assert.AreEqual(19, MyCalc.CountBad());
        }
        [TestMethod]
        public void TestMetod_CountGood()
        {

            Assert.AreEqual(11, MyCalc.CountGood());
        }
        [TestMethod]
        public void TestMetod_CountAll()
        {

            Assert.AreEqual(63, MyCalc.CountAll());
        }
        [TestMethod]
        public void TestMetod_CountDifrent()
        {

            Assert.AreEqual(32, MyCalc.CountDifrent());
        }

    }
}
