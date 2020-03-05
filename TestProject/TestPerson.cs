using NUnit.Framework;
using DipTestingExercises;
using TestProject.Fakes;
using System;

namespace TestProject
{
    public class PersonTests
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
            Assert.AreEqual("John", fakePerson.fname);
            Assert.AreEqual("Doe", fakePerson.lname);
            Assert.AreEqual("Male", fakePerson.getGender());

        }

        [Test]
        public void getName_IsCalled_ReturnsCorrectName()
        {

            Assert.AreEqual("John Doe", fakePerson.getName());

        }

        [Test]
        public void GetGender_IsCalled_ReturnsCorrectGender()
        {
            Assert.AreEqual("Male", fakePerson.getGender());

        }

    }
}