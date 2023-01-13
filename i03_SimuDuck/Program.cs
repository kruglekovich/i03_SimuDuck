using System;

namespace i03_SimuDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck1 = new MallardDuck();
            duck1.display();
            duck1.swim();
            duck1.performquack();
            duck1.performfly();

            RedheadDuck duck2 = new RedheadDuck();
            duck2.display();
            duck2.swim();
            duck2.performquack();
            duck2.performfly();

            RubberDuck duck3 = new RubberDuck();
            duck3.display();
            duck3.swim();
            duck3.performquack();
            duck3.performfly();

            DecoyDuck duck4 = new DecoyDuck();
            duck4.display();
            duck4.swim();
            duck4.performquack();
            duck4.performfly();

            ModelDuck duck5 = new ModelDuck();
            duck5.display();
            duck5.swim();
            duck5.performfly();
            duck5.setFlyBehavior(new FlyRocketPowered());
            duck5.performfly();

        }
    }
}
