using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackbehavior;

        public void performfly()
        {
            flyBehavior.fly();
        }

        public void performquack()
        {
            quackbehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("я плыву !");
        }
        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void  setQuackBehavior(QuackBehavior qb)
        {
            quackbehavior = qb;
        }

        public abstract void display();
    }
}
