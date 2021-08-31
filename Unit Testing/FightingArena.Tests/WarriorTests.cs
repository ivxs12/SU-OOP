using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp]
        public void Setup()
        {
            warrior = new Warrior("name", 1, 2);
        }

        [Test]
        public void CtorTest_DataIntegrityTest()
        {
            Assert.That(warrior.Name, Is.EqualTo("name"));
            Assert.That(warrior.Damage, Is.EqualTo(1));
            Assert.That(warrior.HP, Is.EqualTo(2));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void NameTest_NullOrWhiteSpaceException(string name)
        {
            Assert.Throws<System.ArgumentException>
                (() => new Warrior(name, 1, 2),
                "Name should not be empty or whitespace!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void DamageTest_PositiveValueCheck(int damage)
        {
            Assert.Throws<System.ArgumentException>
                (() => new Warrior("name", damage, 2),
                "Damage value should be positive!");
        }

        [Test]
        [TestCase(-10)]
        [TestCase(-1)]
        public void HPTest_PositiveValueCheck(int hp)
        {
            Assert.Throws<System.ArgumentException>
                (() => new Warrior("name", 1, hp),
                "HP should not be negative!");
        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]
        public void AttackTest_HPValueCheckCurrent(int hp)
        {
            warrior = new Warrior("jake", 1, 30);
            Assert.Throws<System.InvalidOperationException>
                (() => new Warrior("name", 1, hp).Attack(warrior),
                "Your HP is too low in order to attack other warriors!");
        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]
        public void AttackTest_HPValueCheckEnemy(int hp)
        {
            warrior = new Warrior("jake", 1, hp);
            Assert.Throws<System.InvalidOperationException>
                (() => new Warrior("name", 1, 30).Attack(warrior),
                $"Enemy HP must be greater than {30} in order to attack him!");
        }

        [Test]
        [TestCase(30)]
        [TestCase(40)]
        public void AttackTest_IsEnemyStronger(int hp)
        {
            warrior = new Warrior("jake", 50, 50);
            Assert.Throws<System.InvalidOperationException>
                (() => new Warrior("name", 1, hp).Attack(warrior),
                $"You are trying to attack too strong enemy");
        }

        [Test]
        [TestCase(40)]
        public void AttackTest_DataIntegrity(int dmg)
        {
            warrior = new Warrior("jake", 1, 35);

            Warrior warrior2 = new Warrior("name", dmg, 35);
            warrior2.Attack(warrior);
            Assert.That(warrior.HP == 0);
        }

        [Test]
        [TestCase(30)]
        public void AttackTest_DataIntegritySecond(int dmg)
        {
            warrior = new Warrior("jake", 1, 30);

            Warrior warrior2 = new Warrior("name", dmg, 30);
            warrior2.Attack(warrior);
            Assert.That(warrior.HP == 35 - dmg);
        }
    }
}