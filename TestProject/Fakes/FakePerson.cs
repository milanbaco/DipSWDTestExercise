using System;
using System.Collections.Generic;
using System.Text;
using DipTestingExercises;

namespace TestProject.Fakes
{
    class FakePerson : Person
    {
        public FakePerson(string pFname, string pLname, string pGender) : base(pFname, pLname, pGender)
        {
        }
    }
}
