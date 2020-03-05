using NUnit.Framework;
using DipTestingExercises;
using TestProject.Fakes;
using System;

namespace TestProject
{
    public class MotorVehicleTests
    {
        FakeMotorVehicle FMV;
        FakeDriver FDriver;

        [SetUp]

        
        public void Setup()
        {
            FDriver = new FakeDriver("John", "Doe", "Male", "Learners");
            FMV = new FakeMotorVehicle(FDriver, 100, 50, 2);
        }

        [Test]
        public void Constructer_IsCalled_AtttributesAreSet()
        {
            Assert.AreEqual(100, FMV.maxFuel);
            Assert.AreEqual(50, FMV.currentFuel);
            Assert.AreEqual(2, FMV.litresPerKM);
        }


        [Test]
        public void GetFuelRemaining_IsCalled_ReturnsCorrectAmount()
        {
            Assert.AreEqual(50, FMV.getFuelRemaining());
        }

        [Test]
        public void Refuel_EnoughRoom_FuelAmountCorrectlyUpdated()
        {
            // Arrange

            // Act
            FMV.refuel(50);

            // Assert
            Assert.AreEqual(100, FMV.currentFuel);
        }

        [Test]
        public void Refuel_NotEnoughRoom_CorrectExceptionThrown()
        {

            try
            {
                FMV.refuel(51);
                Assert.Fail();
            }
            catch(Exception e)
            {
                  Assert.That(e.Message.Contains("cannot hold that much fuel"));
            }

        }

        [Test]
        public void Refuel_AttemptedNegativeRefuel_CorrectExceptionThrown()
        {

            try
            {
                FMV.refuel(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                Assert.That(e.Message.Contains("stealing fuel"));
            }

        }

        [Test]
        public void Travel_VehicleHasSufficientFuel_ReturnsCorrectFuel()
        {

            FMV.travel(10);

            Assert.AreEqual(30, FMV.getFuelRemaining());
        }
        [Test]
        public void Travel_VehicleHasInsufficientFuel_CorrectExceptionThrown()
        {
            try {
                FMV.travel(26);
                Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.That(e.Message.Contains("Out of Fuel"));
                Assert.That(FMV.currentFuel.Equals(0));
            }
          
        }



    }
}