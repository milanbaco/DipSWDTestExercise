using System;
using System.Collections.Generic;
using System.Text;
using DipTestingExercises;

namespace TestProject.Fakes
{
    class FakeDriver : Driver
    {
        public FakeDriver(string pFname, string pLname, string pGender, string pLicence) : base(pFname, pLname, pGender, pLicence)
        {
        }
    }
}
