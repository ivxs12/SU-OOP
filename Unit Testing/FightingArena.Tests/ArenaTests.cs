using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void CtorTest_WarriorListIntegrity()
        {
            Assert.That(arena.Warriors is IReadOnlyCollection<Warrior>);
        }

        [Test]
        [TestCase("name", 1, 1)]
        public void EnrollTest_ExceptionOnDuplicate(string name, int age, int hp)
        {
            Warrior warrior = new Warrior(name, age, hp);
            arena.Enroll(warrior);
            Assert.Throws
                <System.InvalidOperationException>(
                () => arena.Enroll(new Warrior(name, 2, 2)),
                "Warrior is already enrolled for the fights!");
        }

        [Test]
        [TestCase("name", 1, 1)]
        [TestCase("name2", 2, 2)]
        public void EnrollTest_DataIntegrityCheck(string name, int age, int hp)
        {
            Warrior warrior = new Warrior(name, age, hp);
            arena.Enroll(warrior);
            Assert.That(arena.Warriors.First(), Is.EqualTo(warrior));
        }

        [Test]
        [TestCase("attacker", "jake")]
        [TestCase("jake", "defender")]
        public void FightTest_DataIntegrityCheck(string firstWarrior, string secondWarrior)
        {
            arena.Enroll(new Warrior(firstWarrior, 1, 1));
            arena.Enroll(new Warrior(secondWarrior, 2, 2));
            Assert.Throws
                <System.InvalidOperationException>(() => arena.Fight("attacker", ""),
                $"There is no fighter with name jake enrolled for the fights!");
        }
    }
}
