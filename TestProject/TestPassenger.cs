using NUnit.Framework;
using DipTestingExercises;
using TestProject.Fakes;
using System;

namespace TestProject
{
    public class PassengerTests
    {
        Bus FMV2;
        FakeDriver FDriver2;
        FakePassenger FP;
        FakePassenger FP2;
        FakePerson fakePerson;

        [SetUp]


        public void Setup()
        {
            FDriver2 = new FakeDriver("John", "Doe", "Male", "Learners");
            FP = new FakePassenger("Sam", "Smith", "Male", "Full fare");
            FP2 = new FakePassenger("John", "Smith", "Female", "Full fare");
            FMV2 = new Bus(FDriver2, 100, 50, 2, 1);
            fakePerson = new FakePerson("John", "Doe", "Male");
        }

        [Ignore("We are ignoring this because we don't want to do the work of fixing it!!!")]
        [Test]
        public void Fake_Test() 
        {

        }

        [Test]
        public void Constructer_IsCalled_AtttributesAreSet()
        {
            Assert.AreEqual("Sam", FP.fname);
            Assert.AreEqual("Smith", FP.lname);
            Assert.AreEqual("Male", FP.getGender());
            Assert.AreEqual("Full fare", FP.getTicketType());

        }

        [Test]
        public void getTicketType_IsCalled_ReturnsCorrectLicenceType()
        {

            Assert.AreEqual("Full fare", FP.getTicketType());

        }


    }
}