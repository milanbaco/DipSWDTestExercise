using NUnit.Framework;
using DipTestingExercises;
using TestProject.Fakes;
using System;

namespace TestProject
{
    public class BusTests
    {
        Bus FMV2;
        FakeDriver FDriver2;
        FakePassenger FP;
        FakePassenger FP2;

        [SetUp]


        public void Setup()
        {
            FDriver2 = new FakeDriver("John", "Doe", "Male", "Learners");
            FP = new FakePassenger("Sam", "Smith", "Male", "Full fare");
            FP2 = new FakePassenger("John", "Smith", "Female", "Full fare");
            FMV2 = new Bus(FDriver2, 100, 50, 2, 1);
        }

        [Test]
        public void Constructer_IsCalled_AtttributesAreSet()
        {
            Assert.AreEqual(1, FMV2.maxPassengers);

        }

        [Test]
        public void GetPassenger_IsCalled_ReturnsCorrectAmount()
        {

            Assert.AreEqual(0, FMV2.getPassengerCount());

        }

        [Test]
        public void GetPassenger_BusHasPassenger_ReturnsCorrectAmount()
        {
            FMV2.passengers.Add(FP);
            Assert.AreEqual(1, FMV2.getPassengerCount());

        }

        [Test]
        public void EmbarkPassenger_BusHasRoom_ReturnsCorrectAmount()
        {
            FMV2.embarkPassenger(FP);
            Assert.IsTrue( FMV2.passengers.Contains(FP));

        }

        [Test]
        public void EmbarkPassenger_BusIsFull_ReturnsCorrectAmount()
        {
            

            try
            {
                FMV2.embarkPassenger(FP);
                FMV2.embarkPassenger(FP2);
                   Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.That(e.Message.Contains("Bus"));
                Assert.That(e.Message.Contains("Full"));
                Assert.That(FMV2.passengers.Count == 1);
            }
            

        }



    }
}