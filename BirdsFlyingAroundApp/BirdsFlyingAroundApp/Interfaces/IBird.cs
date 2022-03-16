using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp.Interfaces
{
    public interface IBird
    {
        void SetLocation(double longitude, double latitude);
        void Draw();
    }
}
