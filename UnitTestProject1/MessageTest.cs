using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ConsoleApp1;
using ConsoleApp1.Interface;
using UnitTestProject1.ClasseTest;
using Moq;

namespace UnitTestProject1
{

    [TestClass]
    public class MessageTest
    {
        [TestMethod]
        public void WeekEndTest()
        {
            //------------------- Ici utilisation de Moq -------------------------------------
            IDateTimeMe date = Mock.Of<IDateTimeMe>();
            Mock.Get(date).Setup(m => m.getDateNow()).Returns(new DateTime(2019, 11, 17, 12, 0, 0));

            //IDateTimeMe date = new DateTimeMeFakeWeekEnd();
            Message _message = new Message(date, new EnvironementMeFake(), 9, 13, 18);
            
            String res = _message.GetHelloMessage();
            Assert.AreEqual(res, "Bon week-end Babar !");
           
        }

        [TestMethod]
        public void BonjourTest()
        {
            //------------------- Ici utilisation de Moq -------------------------------------
            IDateTimeMe date = Mock.Of<IDateTimeMe>();
            Mock.Get(date).Setup(m => m.getDateNow()).Returns(new DateTime(2019, 11, 18, 10, 0, 0));

            //IDateTimeMe date = new DateTimeMeFakeBonjour();
            Message _message = new Message(date, new EnvironementMeFake(), 9, 13, 18);

            String res = _message.GetHelloMessage();
            Assert.AreEqual(res, "Bonjour Babar !");
        }

        [TestMethod]
        public void ApresMidiTest()
        {
            //------------------- Ici utilisation de Moq -------------------------------------
            IDateTimeMe date = Mock.Of<IDateTimeMe>();
            Mock.Get(date).Setup(m => m.getDateNow()).Returns(new DateTime(2019, 11, 18, 15, 0, 0));

            //IDateTimeMe date = new DateTimeMeFakeApresMidi();
            Message _message = new Message(date, new EnvironementMeFake(), 9, 13, 18);

            String res = _message.GetHelloMessage();
            Assert.AreEqual(res, "Bon après midi Babar !");
        }

        [TestMethod]
        public void BonsoirTest()
        {
            //------------------- Ici utilisation de Moq -------------------------------------
            IDateTimeMe date = Mock.Of<IDateTimeMe>();
            Mock.Get(date).Setup(m => m.getDateNow()).Returns(new DateTime(2019, 11, 18, 20, 0, 0));

            //IDateTimeMe date = new DateTimeMeFakeBonsoir();
            Message _message = new Message(date, new EnvironementMeFake(), 9, 13, 18);

            String res = _message.GetHelloMessage();
            Assert.AreEqual(res, "Bonsoir Babar !");
        }
    }
}
