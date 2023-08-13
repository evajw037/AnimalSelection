using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SD6503BenchmarkApp;
using System.Collections.Generic;

namespace BMUnitTests
{
    [TestClass]
    public class CretureUnitTest 
    {
        [TestMethod]
        public void TestCreatureCreatureName()
        {
            Creature c = new Creature();
            c.CreatureName = "Fluffy";
            Assert.AreEqual("Fluffy", c.CreatureName);
        }
        [TestMethod]
        public void TestCreatureAge()
        {
            Creature c = new Creature();
            c.Age = "123";
            Assert.AreEqual("123",c.Age);
        }
        [TestMethod]
        public void TestCreatureOwner()
        {
            Creature c = new Creature();
            c.Owner = "Fred";
            Assert.AreEqual("Fred", c.Owner);
        }
        [TestMethod]
        public void TestCreatureConstructor()
        {
            Creature c = new Creature();
            Assert.AreEqual("NA", c.CreatureName, "Name Fail");
            Assert.AreEqual("0", c.Age, "Age Fail");
            Assert.AreEqual("NA", c.Owner, "Owner Fail");
        }

        [TestMethod]
        public void TestCreatureToStringFormat()
        {
            Creature c = new Creature();
            c.CreatureName = "Flipper";
            c.Age = "10";
            c.Owner = "Fred";
            Assert.AreEqual("Flipper", c.ToString());
        }
    }
}
