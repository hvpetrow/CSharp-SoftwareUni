namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class RobotsTests
    {
        RobotManager robotManager;
        int capacity = 10;

        [SetUp]
        public void SetUp()
        {
            robotManager = new RobotManager(capacity);
        }

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            string name = "Pesho";
            int battery = 100;

            Robot robot = new Robot("Pesho", 100);

            Assert.AreEqual(name, robot.Name);
            Assert.AreEqual(battery, robot.Battery);
            Assert.AreEqual(battery, robot.MaximumBattery);
        }

        [Test]
        public void RobotManagerConstructorShouldWorkProperly()
        {
            int capacity = 200;

            RobotManager robotManager = new RobotManager(capacity);

            Assert.IsNotNull(robotManager);
            Assert.IsNotNull(robotManager.Count);
            Assert.AreEqual(capacity, robotManager.Capacity);
            Assert.AreEqual(robotManager.Count, 0);
        }

        [Test]
        public void CapacityPropInvalidDataTest()
        {
            int capacity = -1;


            var ex = Assert.Throws<ArgumentException>(()
                 => new RobotManager(capacity));

            string expectedExMessage = "Invalid capacity!";
            Assert.AreEqual(expectedExMessage, ex.Message);
        }

        [Test]
        public void AddMethodShouldWorkProperly()
        {
            robotManager.Add(new Robot("Minco", 50));
            robotManager.Add(new Robot("Gosho", 100));

            Assert.AreEqual(2, robotManager.Count);
        }

        [Test]
        public void AddMethodShouldThrowExIfNameAlreadyExist()
        {
            Robot robot = new Robot("Gosho", 150);
            robotManager.Add(new Robot("Minco", 50));
            robotManager.Add(new Robot("Gosho", 100));

            var expectedExMessage = $"There is already a robot with name {robot.Name}!";
            var ex = Assert.Throws<InvalidOperationException>(()
                 => robotManager.Add(robot));
            Assert.AreEqual(expectedExMessage, ex.Message);
        }

        [Test]
        public void AddMethodShouldThrowExIfCapacityIsAlreadyFull()
        {
            Robot robot = new Robot("Pencho", 150);
            RobotManager rb = new RobotManager(3);

            rb.Add(new Robot("Minco", 50));
            rb.Add(new Robot("Gosho", 100));
            rb.Add(new Robot("Pepi", 300));

            var expectedExMessage = $"Not enough capacity!";
            var ex = Assert.Throws<InvalidOperationException>(()
                 => rb.Add(robot));
            Assert.AreEqual(expectedExMessage, ex.Message);
        }

        [Test]
        public void RemoveMethodShouldWorkCorrectly()
        {
            Robot robot = new Robot("Gosho", 150);
            string removedName = "Gosho";

            robotManager.Add(new Robot("Minco", 50));
            robotManager.Add(robot);
            robotManager.Remove(removedName);

            Assert.AreEqual(1, robotManager.Count);
        }

        [Test]
        public void RemoveMethodShouldThrowExIfRobotIsNull()
        {
            Robot robot = new Robot("Gosho", 150);
            string removedName = "Perikal";

            robotManager.Add(new Robot("Minco", 50));
            robotManager.Add(new Robot("Penko", 50));
            robotManager.Add(robot);

            var expected = $"Robot with the name {removedName} doesn't exist!";
            var ex = Assert.Throws<InvalidOperationException>(()
                => robotManager.Remove(removedName));
            Assert.AreEqual(expected, ex.Message);

        }

        [Test]
        public void WorkMethodShouldThrowExIfRobotIsNull()
        {
            Robot robot = new Robot("Gosho", 150);
            string robotName = "Perikal";
            string job = "Cleaner";
            int batteryUsage = 100;

            robotManager.Add(new Robot("Minco", 50));
            robotManager.Add(new Robot("Penko", 50));
            robotManager.Add(robot);

            var expected = $"Robot with the name {robotName} doesn't exist!";
            var ex = Assert.Throws<InvalidOperationException>(()
                => robotManager.Work(robotName,job,batteryUsage));
            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void WorkMethodShouldThrowExIfRobotIsBatteryIsNotEnough()
        {
            Robot robot = new Robot("Gosho", 150);
            string robotName = "Gosho";
            string job = "Cleaner";
            int batteryUsage = 200;

            robotManager.Add(new Robot("Minco", 50));
            robotManager.Add(new Robot("Penko", 50));
            robotManager.Add(robot);

            var expected = $"{robot.Name} doesn't have enough battery!";
            var ex = Assert.Throws<InvalidOperationException>(()
                => robotManager.Work(robotName, job, batteryUsage));
            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void WorkMethodShouldWorkCorrectly()
        {
            Robot robot = new Robot("Gosho", 150);
            string robotName = "Gosho";
            string job = "Cleaner";
            int batteryUsage = 140;
            int expectedBattery = robot.Battery - batteryUsage;

            robotManager.Add(new Robot("Minco", 50));
            robotManager.Add(robot);

            robotManager.Work(robotName, job, batteryUsage);

            Assert.AreEqual(expectedBattery, robot.Battery);
        }

        [Test]
        public void ChargeMethodShouldThrowExIfRobotIsNull()
        {
            Robot robot = new Robot("Gosho", 150);
            string searchedRobotName = "Perikal";

            robotManager.Add(new Robot("Penko", 50));
            robotManager.Add(robot);

            var expected = $"Robot with the name {searchedRobotName} doesn't exist!";
            var ex = Assert.Throws<InvalidOperationException>(()
                => robotManager.Charge(searchedRobotName));
            Assert.AreEqual(expected, ex.Message);
        }

        [Test]
        public void ChargeMethodShouldWorkCorrectly()
        {
            Robot robot = new Robot("Gosho", 150);
            string searchedRobotName = "Gosho";
            string job = "Cleaner";
            int batteryUsage = 140;

            robotManager.Add(new Robot("Penko", 50));
            robotManager.Add(robot);
            robotManager.Work(searchedRobotName, job, batteryUsage);

            robotManager.Charge(searchedRobotName);

            Assert.AreEqual(robot.Battery, robot.MaximumBattery);
        }
    }
}
