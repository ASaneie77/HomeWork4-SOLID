using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.BadPractice
{
    public interface IMultiFunctionDevice
    {
        void Print();
        void Scan();
        void Fax();
    }

    public class HighEndPrinter : IMultiFunctionDevice
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => Console.WriteLine("Scanning...");
        public void Fax() => Console.WriteLine("Faxing...");
    }

    public class BasicPrinter : IMultiFunctionDevice
    {
        public void Print() => Console.WriteLine("Printing...");

        public void Scan()
        {
            throw new NotImplementedException("I can't scan!");
        }

        public void Fax()
        {
            throw new NotImplementedException("I can't fax!");
        }
    }

}
