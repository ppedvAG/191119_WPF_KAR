using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreatePeopleReturnsCorrectAmount()
        {
            PersonenService service = new PersonenService();

            var result = service.CreatePeople(10);

            Assert.AreEqual(10, result.Count);
        }
    }
}
