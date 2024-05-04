using System;
using System.IO;
using System.Threading.Tasks;

// The 'IFileReader' interface declares the methods that all concrete products must implement.

// Concrete Products provide various implementations of the IFileReader interface.

// The 'IReaderFactory' interface declares a method that should return a new instance of an IFileReader.

// Concrete Factories produce a family of products that belong to a single variant.

// The client code works with factories and products only through abstract types.
class Program
{
    static void Main(string[] args)
    {
        IReaderFactory factory;
        IFileReader fileReader;

        // Decide at runtime which factory to use
        if (args.Length > 0 && args[0] == "async")
        {
            factory = new AsyncReaderFactory();
        }
        else
        {
            factory = new SyncReaderFactory();
        }

        fileReader = factory.CreateFileReader("example.txt");

        Console.WriteLine(fileReader.ReadFile());
    }
}
