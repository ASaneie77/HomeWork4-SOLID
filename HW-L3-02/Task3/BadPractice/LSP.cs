using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BadPractice
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("I am flying!");
        }
    }

    public class Eagle : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle flying!");
        }
    }

    public class Ostrich : Bird 
    {
        public override void Fly()
        {
            throw new InvalidOperationException("Ostrich cannot fly!");
        }
    }
}
