using System;

namespace DucksPattern.Abitities.Fly
{
    public class CanFly : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Умеет летать");
        }
    }
}