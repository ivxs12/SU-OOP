using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;
        private int[] defaultInput = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        [SetUp]
        public void Setup()
        {
            this.database = new Database();
        }

        [Test]
        public void CtorTest_ThrownExceptionWhenDbExceedsCount()
        {
            Assert.That(
                () => database = new Database
                (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17),
                Throws.InvalidOperationException, "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void CtorTest_AddValidItemsToDB()
        {
            database = new Database(defaultInput);
            Assert.AreEqual(defaultInput, database.Fetch());
            Assert.IsTrue(database.Fetch().First() is int);
        }

        [Test]
        public void RemoveTest_RemoveLastElement()
        {
            database = new Database(defaultInput);
            database.Remove();
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Assert.AreEqual(expected, database.Fetch());
        }

        [Test]
        public void RemoveTest_DecreaseCount()
        {
            int count = defaultInput.Count();
            database = new Database(defaultInput);

            Assert.IsTrue(count == database.Count);

        }

        [Test]
        public void RemoveTest_RemoveFromEmptyCollection()
        {
            Assert.That
                (() => database.Remove(),
                Throws.InvalidOperationException,
                "The collection is empty!");
        }

        [Test]
        public void FetchTest_ReturnAsArray()
        {
            Assert.IsTrue(database.Fetch() is int[]);
        }
    }
}