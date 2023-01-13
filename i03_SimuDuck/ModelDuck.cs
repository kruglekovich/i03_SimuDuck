using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackbehavior = new MuteQuack();
        }
        public override void display()
        {
            Console.WriteLine("modelDuck");
        }
    }
}
