using ClassLibraryCykel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCykel
{
    [TestClass]
    public class UnitTest1
    {
        Cykel cykel;

        [TestInitialize]
        public void Init()
        {
            cykel = new Cykel();
        }

        [TestMethod]
        public void TestConstructor()
        {
            cykel = null;
            cykel = new Cykel(1, "rød", 1999.95, 4);
            Assert.IsNotNull(cykel);
        }

        [TestMethod]
        public void TestId()
        {
            cykel.Id = 5;
            Assert.AreEqual(5, cykel.Id);
        }

        [TestMethod]
        public void TestFarve()
        {
            cykel.Farve = "";
            Assert.AreNotEqual("", cykel.Farve);
        }

        [TestMethod]
        public void TestPris()
        {
            cykel.Pris = 0;
            Assert.AreNotEqual(0, cykel.Pris);
        }

        [TestMethod]
        public void TestGear()
        {
            cykel.Gear = 32;
            Assert.AreEqual(32, cykel.Gear);
            cykel.Gear = 33;
            Assert.AreNotEqual(33, cykel.Gear);
            cykel.Gear = 2;
            Assert.AreNotEqual(2, cykel.Gear);
        }


    }
}
