using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.GoodPractice
{
    public class Bird
    {
        public string Name { get; set; }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Eagle : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Eagle is flying high!");
        }
    }

    public class Ostrich : Bird
    {
    }

}
