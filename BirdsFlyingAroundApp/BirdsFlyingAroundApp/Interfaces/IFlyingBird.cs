using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp.Interfaces
{
    public interface IFlyingBird : IBird
    {
        void SetAltitude(double altitude);
    }
}
