using System;
using DucksPattern.Abitities.Fly;
using DucksPattern.Abitities.Quack;
using DucksPattern.Abitities.Swim;

namespace DucksPattern
{
    public abstract class Duck
    {
        private IFlying _flying;
        private IQuacking _quacking;
        private ISwimming _swimming;

        protected Duck(IFlying flying, IQuacking quacking, ISwimming swimming)
        {
            _flying = flying;
            _quacking = quacking;
            _swimming = swimming;
        }

        // Информация об уточке
        public virtual void Display()
        {
            _flying.Fly();
            _quacking.Quack();
            _swimming.Swim();
        }

        // Убийство уточки
        public void Dead()
        {
            _flying = new NoFlying();
            _quacking = new NoQuacking();
            _swimming = new NoSwimming();
            Console.WriteLine("Уточка мертва");
        }
    }
}