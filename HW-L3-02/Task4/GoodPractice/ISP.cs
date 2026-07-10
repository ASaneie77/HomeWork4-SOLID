using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4.GoodPractice
{
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public interface IFaxMachine
    {
        void Fax();
    }

    public class HighEndPrinter : IPrinter, IScanner, IFaxMachine
    {
        public void Print() => Console.WriteLine("Printing...");
        public void Scan() => Console.WriteLine("Scanning...");
        public void Fax() => Console.WriteLine("Faxing...");
    }

    public class BasicPrinter : IPrinter
    {
        public void Print() => Console.WriteLine("Printing...");
    }

}
