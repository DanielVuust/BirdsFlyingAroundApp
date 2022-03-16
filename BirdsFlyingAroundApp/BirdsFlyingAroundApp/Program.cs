using BirdsFlyingAroundApp.Birds;
using BirdsFlyingAroundApp.Interfaces;
using System;
using System.Collections.Generic;

namespace BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IBird duck = new Duck();
            IBird blackBrird = new BlackBird();
            List<IBird> birdList = new List<IBird>()
            {
                duck,
                blackBrird
            };
            foreach(IBird bird in birdList)
            {
                bird.Draw();
                bird.SetLocation(1, 2);
            }
            Console.Read();
        }
    }
}
