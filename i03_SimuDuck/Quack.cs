using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i03_SimuDuck
{
    class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("кря-кря говорит уточка");
        }
    }
}
