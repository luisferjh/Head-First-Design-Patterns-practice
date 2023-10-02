using SimUDuckApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuckApp.Classes
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public void performQuack() 
        {
            quackBehavior.quack();
        }

        public void performFly()
        {
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(FlyBehavior fly) 
        {
            flyBehavior = fly;
        }

        public void SetFlyBehavior(QuackBehavior quack)
        {
            quackBehavior = quack;
        }

        protected void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public abstract void Display();


    }
}
