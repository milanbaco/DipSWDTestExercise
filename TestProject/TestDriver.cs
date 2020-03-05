using NUnit.Framework;
using DipTestingExercises;
using TestProject.Fakes;
using System;

namespace TestProject
{
    public class DriverTests
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

        [Test]
        public void Constructer_IsCalled_AtttributesAreSet()
        {
            Assert.AreEqual("John", FDriver2.fname);
            Assert.AreEqual("Doe", FDriver2.lname);
            Assert.AreEqual("Male", FDriver2.getGender());
            Assert.AreEqual("Learners", FDriver2.getLicenceType());

        }

        [Test]
        public void getLicenceType_IsCalled_ReturnsCorrectLicenceType()
        {

            Assert.AreEqual("Learners", FDriver2.getLicenceType());

        }


    }
}