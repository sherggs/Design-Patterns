using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SegregationPrinciple
{
    public class Document
    {

    }
    public interface IMachine
    {
        void Print(Document D);
        void Scan(Document D);
        void Fax(Document D);
    }
    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document D)
        {
            throw new NotImplementedException();
        }

        public void Print(Document D)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document D)
        {
            throw new NotImplementedException();
        }
    }

    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document D)
        {
            throw new NotImplementedException();
        }

        public void Print(Document D)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document D)
        {
            throw new NotImplementedException();
        }
    }
    public interface IPrinter
    {
        void Print(Document D);
    }
    public interface IScanner
    {
        void Scan(Document D);
    }
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document D)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document D)
        {
            throw new NotImplementedException();
        }
    }
    public interface iMultiFunctionDevice : IPrinter, IScanner
    {
        //Public interface for multifunctional interfaces.
    }
    public class MultiFunctionMachine : iMultiFunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;
        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            if (printer == null)
                throw new ArgumentNullException(paramName: nameof(printer));
            if (scanner == null)
                throw new ArgumentNullException(paramName: nameof(scanner));
            this.printer = printer;
            this.scanner = scanner;
        }
        public void Print(Document D)
        {
            printer.Print(D);
        }

        public void Scan(Document D)
        {
            scanner.Scan(D);
        }
    }




    public class Segregation
    {
        static void Main(string[] args)
        {

        }
    }
}