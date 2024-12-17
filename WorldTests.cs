using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD3.Tests
{
    [TestClass()]
    public class WorldTests
    {
        [TestMethod()]
        public void GetInstance_Singleton_ShouldReturnSameInstance()
        {
            World instance1 = World.GetInstance();
            World instance2 = World.GetInstance();

            Assert.AreSame(instance1, instance2);
        }

        [TestMethod()]
        public void DetermineSeason_SpringNorth_ShouldReturnSpring()
        {
            World world = World.GetInstance();
            world.Latitude = 50.0;
            world.Day = 100;

            string season = world.DetermineSeason();

            Assert.AreEqual("Spring", season);
        }

        [TestMethod()]
        public void DetermineSeason_SummerNorth_ShouldReturnSummer()
        {
            World world = World.GetInstance();
            world.Latitude = 50.0;
            world.Day = 180;

            string season = world.DetermineSeason();

            Assert.AreEqual("Summer", season);
        }

        [TestMethod()]
        public void DetermineSeason_AutumnNorth_ShouldReturnAutumn()
        {
            World world = World.GetInstance();
            world.Latitude = 50.0;
            world.Day = 280;

            string season = world.DetermineSeason();

            Assert.AreEqual("Autumn", season);
        }

        [TestMethod()]
        public void DetermineSeason_WinterNorth_ShouldReturnWinter()
        {
            World world = World.GetInstance();
            world.Latitude = 50.0;
            world.Day = 10;

            string season = world.DetermineSeason();

            Assert.AreEqual("Winter", season);
        }

        [TestMethod()]
        public void DetermineSeason_AutumnSouth_ShouldReturnAutumn()
        {
            World world = World.GetInstance();
            world.Latitude = -50.0;
            world.Day = 100;

            string season = world.DetermineSeason();

            Assert.AreEqual("Autumn", season);
        }

        [TestMethod()]
        public void DetermineSeason_WinterSouth_ShouldReturnWinter()
        {
            World world = World.GetInstance();
            world.Latitude = -50.0;
            world.Day = 180;

            string season = world.DetermineSeason();

            Assert.AreEqual("Winter", season);
        }

        [TestMethod()]
        public void DetermineSeason_SpringSouth_ShouldReturnSpring()
        {
            World world = World.GetInstance();
            world.Latitude = -50.0;
            world.Day = 280;

            string season = world.DetermineSeason();

            Assert.AreEqual("Spring", season);
        }

        [TestMethod()]
        public void DetermineSeason_SummerSouth_ShouldReturnSummer()
        {
            World world = World.GetInstance();
            world.Latitude = -50.0;
            world.Day = 10; 

            string season = world.DetermineSeason();

            Assert.AreEqual("Summer", season);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DetermineSeason_DayGreaterThan365_ShouldThrowArgumentOutOfRangeException()
        {
            World world = World.GetInstance();
            world.Day = 400;
            world.Latitude = 50.45;
            world.City = "Kyiv";

            world.DetermineSeason();
        }
    }
}
