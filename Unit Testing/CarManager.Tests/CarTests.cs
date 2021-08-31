using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("make", "model", 0.1, 0.2);
        }

        [Test]
        public void CtorTest_CtorFunctionality()
        {
            Assert.That(car.FuelAmount, Is.EqualTo(0));
            Assert.That(car.Make, Is.EqualTo("make"));
            Assert.That(car.Model, Is.EqualTo("model"));
            Assert.That(car.FuelConsumption, Is.EqualTo(0.1));
            Assert.That(car.FuelCapacity, Is.EqualTo(0.2));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void MakeTest_NullOrEmptyCheck(string make)
        {
            Assert.That(() => new Car(make, "model", 0.1, 0.2),
                Throws.ArgumentException,
                "Make cannot be null or empty!");
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ModelTest_NullOrEmptyCheck(string model)
        {
            Assert.That(() => new Car("make", model, 0.1, 0.2),
                Throws.ArgumentException,
                "Model cannot be null or empty!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void ConsumptionTest_ZeroOrNegativeCheck(double consumption)
        {
            Assert.That(() => new Car("make", "model", consumption, 0.2),
                Throws.ArgumentException,
                "Fuel consumption cannot be zero or negative!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CapacityTest_ZeroOrNegativeCheck(double capacity)
        {
            Assert.That(() => new Car("make", "model", 0.1, capacity),
                Throws.ArgumentException,
                "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void RefuelTest_ZeroOrNegativeCheck(double fuel)
        {
            Assert.That(() => new Car("make", "model", 0.1, 0.2).Refuel(fuel),
                Throws.ArgumentException,
                "Fuel amount cannot be zero or negative!");        
        }

        [Test]
        [TestCase(100)]
        public void RefuelTest_FuelToCapacityCheck(double fuel)
        {
            car.Refuel(fuel);
            Assert.That(car.FuelAmount, Is.EqualTo(car.FuelCapacity));
        }

        [Test]
        [TestCase(100)]
        public void RefuelTest_RefilCheck(double fuel)
        {
            car = new Car("make", "model", 0.1, 1000);
            car.Refuel(fuel);
            Assert.That(car.FuelAmount, Is.EqualTo(fuel));
        }

        [Test]
        [TestCase(100)]
        public void DriveTest_FuelAmountCheck(double km)
        {
            car = new Car("make", "model", 1, 0.2);
            car.Refuel(km);
            Assert.That(() => car.Drive(km),
                Throws.InvalidOperationException,
                "You don't have enough fuel to drive!");
        }
        [Test]
        [TestCase(100)]
        public void DriveTest_FuelNeededCheck(double km)
        {
            double fuelNeeded = (km / 100) * 1;
            Assert.That(fuelNeeded, Is.EqualTo(1));
        }

        [Test]
        [TestCase(100)]
        public void DriveTest_FuelSubstractCheck(double km)
        {
            double fuelNeeded = (km / 100) * 1;
            car = new Car("make", "model", 1, 100);
            car.Refuel(100);
            car.Drive(km);
            Assert.That(car.FuelAmount, Is.EqualTo(100 - fuelNeeded));
        }

    }
}