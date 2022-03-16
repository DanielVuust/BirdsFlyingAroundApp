using BirdsFlyingAroundApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp.BirdTypes
{
    public abstract class SwimmingAndFlyingBird : IFlyingBird, ISwimmingBird
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Bird");
        }

        public virtual void SetAltitude(double altitude)
        {
            Console.WriteLine("Setting altutude");
        }

        public virtual void SetDepth()
        {
            Console.WriteLine("Setting Depth");
        }

        public virtual void SetLocation(double longitude, double latitude)
        {
            Console.WriteLine("Setting Location");
        }
    }
}
