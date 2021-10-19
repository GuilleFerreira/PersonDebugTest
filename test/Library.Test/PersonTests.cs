using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void TestName() // Test nombre
        {
            Person gonza = new Person("Gonzalo", "5.219.613-0","17/06/21");
            string expected = "Gonzalo";
            Assert.AreEqual(expected,gonza.Name);
        }

        [Test]
        public void TestID() // Test cédula
        {
            Person gonza = new Person("Gonzalo", "5.219.613-0","17/06/21");
            string expected = "5.219.613-0";
            Assert.AreEqual(expected,gonza.ID);
        }

        [Test]
        public void TestBday() // Test fecha de cumpleaños
        {
            Person gonza = new Person("Gonzalo", "5.219.613-0","17/06/20");
            string expected = "17/06/20";
            Assert.AreEqual(expected,gonza.Bday);
            
        }
    }
}