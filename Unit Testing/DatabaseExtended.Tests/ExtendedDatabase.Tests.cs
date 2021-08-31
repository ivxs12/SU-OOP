using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase database;

        [SetUp]
        public void Setup()
        {
            this.database = new ExtendedDatabase();
        }

        [Test]
        public void CtorTest_InitialCapacityCheck()
        {
            Person[] people = new Person[5];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, i.ToString());
            }
            Assert.That
                (() => new ExtendedDatabase(people).Count == people.Length);

            database = new ExtendedDatabase(people);
            foreach (var person in people)
            {
                Person persona = database.FindById(person.Id);
                Assert.That(person, Is.EqualTo(persona));
            }
        }

        [Test]
        public void CtorTest_ThrowExceptionWhenExceedCount()
        {
            Person[] people = new Person[17];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, i.ToString());
            }
            Assert.That
                (() => new ExtendedDatabase(people),
                Throws.ArgumentException,
                "Provided data length should be in range [0..16]!");
        }

        [Test]
        public void AddRangeTest_ExceedCount()
        {
            Person[] people = new Person[17];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, i.ToString());
            }
            Assert.That
                (() => new ExtendedDatabase(people),
                Throws.ArgumentException,
                "Provided data length should be in range [0..16]!");
        }

        [Test]
        public void AddTest_ThrowExceptionWhenExceedCount()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(new Person(i, i.ToString()));
            }
            Assert.That
                (() => database.Add(new Person(17, null)),
                Throws.InvalidOperationException,
                "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void AddTest_ThrowExceptionWhenDuplicateName()
        {
            database.Add(new Person(16, "14"));
            Assert.That
                (() => database.Add(new Person(16, "14")),
                Throws.InvalidOperationException,
                "There is already user with this username!");
        }

        [Test]
        public void AddTest_ThrowExceptionWhenDuplicateId()
        {
            database.Add(new Person(14, "15"));
            Assert.That
                (() => database.Add(new Person(14, "15")),
                Throws.InvalidOperationException,
                "There is already user with this Id!");
        }

        [Test]
        public void AddTest_IncreasesCount()
        {
            int count = 1;
            database.Add(new Person(14, "15"));
            Assert.IsTrue(count == database.Count);
        }

        [Test]
        public void RemoveTest_DecreaseCount()
        {
            int count = 0;
            database.Add(new Person(1, "1"));
            database.Remove();
            Assert.IsTrue(count == database.Count);
        }

        [Test]
        public void RemoveTest_RemoveLast()
        {
            database.Add(new Person(1, "1"));
            database.Add(new Person(2, "2"));
            database.Remove();
            Assert.Throws<System.InvalidOperationException>
                (() => database.FindById(2), "No user is present by this ID!");
            Assert.That(database.Count == 1);
        }

        [Test]
        public void RemoveTest_RemoveFromEmptyCollection()
        {
            Assert.That
                (() => database.Remove(),
                Throws.InvalidOperationException,
                string.Empty);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByNameTest_SearchByEmptyOrNull(string username)
        {
            Assert.That(() => database.FindByUsername(username),
                Throws.ArgumentNullException,
                "Username parameter is null!");
        }

        [Test]
        public void FindByNameTest_CaseSensitive()
        {
            database.Add(new Person(14, "Gosho"));
            Assert.That(() => database.FindByUsername("GoSho"),
                Throws.InvalidOperationException,
                "No user is present by this username!");
        }

        [Test]
        public void FindByNameTest_ReturnsRightResult()
        {
            Person person = new Person(14, "Gosho");
            database.Add(person);
            Assert.That(() => database.FindByUsername("Gosho") == person);
        }

        [Test]
        public void FindByNameTest_SearchForNonExistingName()
        {
            Assert.That(() => database.FindByUsername("Gosho"),
                Throws.InvalidOperationException,
                "No user is present by this username!");
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-15)]
        public void FindByIdTest_SearchByNegativeId(int id)
        {
            Assert.Throws<System.ArgumentOutOfRangeException>
                (() => database.FindById(id), "Id should be a positive number!");
        }

        [Test]
        [TestCase(1)]
        public void FindByIdTest_SearchForNonExistingId(int id)
        {
            Assert.That(() => database.FindById(id),
                Throws.InvalidOperationException,
                "No user is present by this ID!");
        }

        [Test]
        public void FindByIdTest_ReturnsRightResult()
        {
            Person person = new Person(14, "Gosho");
            database.Add(person);
            Assert.That(() => database.FindById(14) == person);
        }

    }
}