using System;
using System.Collections.Generic;
using System.Text;
using DipTestingExercises;

namespace TestProject.Fakes
{
    class FakeMotorVehicle : MotorVehicle
    {
        public FakeMotorVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM) : base(pDriver, pMax, pCurrent, pLitresPerKM)
        {
        }
    }
}
